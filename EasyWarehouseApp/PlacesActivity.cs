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

namespace EasyWarehouseApp
{
    [Activity(Label = "PlacesActivity", Theme = "@style/AppTheme")]
    public class PlacesActivity : Activity
    {
        #region Разметка

        [BindView(Resource.Id.toolbar)]
        private Toolbar toolbar;
        [BindView(Resource.Id.listViewPlaces)]
        private ListView listViewPlaces;

        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            #region Разметка

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_places);
            Cheeseknife.Bind(this);
            SetActionBar(toolbar);
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.Title = "Места";

            #endregion

            var places = StaticData.Places.ToWebModel()
                .Select(p => $"{p.Name} | {p.CountProducts} | {p.Size}");
            var placesAdapter =
                new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, places.ToArray());
            listViewPlaces.Adapter = placesAdapter;

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