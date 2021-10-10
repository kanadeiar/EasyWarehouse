using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using CheeseBind;

namespace EasyWarehouseApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        #region Разметка

        [BindView(Resource.Id.buttonProducts)]
        private Button buttonProducts;
        [BindView(Resource.Id.buttonPlaces)]
        private Button buttonPlaces;
        [BindView(Resource.Id.buttonAdd)]
        private Button buttonAdd;
        [BindView(Resource.Id.buttonDelete)]
        private Button buttonDelete;

        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Cheeseknife.Bind(this);

            buttonProducts.Click += (o, e) =>
            {
                var productsIntent = new Intent(this, typeof(ProductsActivity));
                StartActivity(productsIntent);
            };
            buttonPlaces.Click += (o, e) =>
            {
                var placesIntent = new Intent(this, typeof(PlacesActivity));
                StartActivity(placesIntent);
            };
            buttonAdd.Click += (o, e) =>
            {
                var addIntent = new Intent(this, typeof(AddActivity));
                StartActivity(addIntent);
            };
            buttonDelete.Click += (o, e) =>
            {
                var deleteIntent = new Intent(this, typeof(DeleteActivity));
                StartActivity(deleteIntent);
            };


        }

        #region Хлам

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        #endregion
    }
}