using System.Linq;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using CheeseBind;
using Warehouse.Domain.Models.Data;

namespace EasyWarehouseApp
{
    [Activity(Label = "ProductsActivity", Theme = "@style/AppTheme")]
    public class ProductsActivity : Activity
    {
        #region Разметка

        [BindView(Resource.Id.toolbar)]
        private Toolbar toolbar;
        [BindView(Resource.Id.listViewProducts)]
        private ListView listViewProducts;

        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            #region Разметка

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_products);
            Cheeseknife.Bind(this);
            SetActionBar(toolbar);
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.Title = "Товары";

            #endregion

            var products = StaticData.Products.ToWebModel()
                .Select(p => $"{p.Name} | {p.PlaceName} | {p.DateTime.ToString("dd MMMM yyyy hh:mm")}");
            var productsAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, products.ToArray());
            listViewProducts.Adapter = productsAdapter;

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