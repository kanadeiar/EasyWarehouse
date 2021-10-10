using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheeseBind;
using Warehouse.Domain.Models.Data;
using ZXing.Mobile;

namespace EasyWarehouseApp
{
    [Activity(Label = "AddActivity", Theme = "@style/AppTheme")]
    public class AddActivity : Activity
    {
        #region Разметка

        [BindView(Resource.Id.toolbar)]
        private Toolbar toolbar;
        [BindView(Resource.Id.buttonAddScan)]
        private Button buttonAddScan;
        [BindView(Resource.Id.editTextId)]
        private EditText editTextId;
        [BindView(Resource.Id.editTextName)]
        private EditText editTextName;
        [BindView(Resource.Id.editTextPlace)]
        private EditText editTextPlace;
        [BindView(Resource.Id.editTextDate)]
        private EditText editTextDate;

        #endregion

        private MobileBarcodeScanner scanner;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            #region Разметка

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_add);
            Cheeseknife.Bind(this);
            SetActionBar(toolbar);
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.Title = "Добавить";

            #endregion

            MobileBarcodeScanner.Initialize(Application);
            scanner = new MobileBarcodeScanner();

            buttonAddScan.Click += (o, e) =>
            {
                RunScan();
            };
        }

        private async void RunScan()
        {
            scanner.UseCustomOverlay = false;
            scanner.TopText = "Поместите штрих-код в видоискатель камеры для его сканирования.";
            scanner.BottomText =
                "Штрих-код сканируется автоматически. Избегайте теней и бликов. Соблюдайте расстояние 15 см";

            var result = await scanner.Scan(new MobileBarcodeScanningOptions { AutoRotate = false });

            if (result != null && !string.IsNullOrEmpty(result.Text))
            {
                if (result.Text.StartsWith("EWHONE") && int.TryParse(result.Text.Substring(6), out int value))
                {
                    Toast.MakeText(this, $"Штрих-код успешно распознан: {value}", ToastLength.Short)?.Show();

                    var product = StaticData.Products.SingleOrDefault(p => p.Id == value).ToWebModel();

                    if (product != null)
                    {
                        editTextId.Text = product.Id.ToString();
                        editTextName.Text = product.Name;
                        editTextPlace.Text = product.PlaceName;
                        editTextDate.Text = product.DateTime.ToString("dd MMMM yyyy HH:mm");
                    }
                }
                else
                {
                    Toast.MakeText(this, "Не удалось распознать штрих-код: " + result.Text, ToastLength.Short)?.Show();
                }
            }
            else
            {
                Toast.MakeText(this, "Сканирование отменено", ToastLength.Short)?.Show();
            }
        }

        #region Меню

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            switch (id)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }

        #endregion
    }
}