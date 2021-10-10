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

namespace EasyWarehouseApp
{
    [Activity(Label = "DeleteActivity", Theme = "@style/AppTheme")]
    public class DeleteActivity : Activity
    {
        #region Разметка

        [BindView(Resource.Id.toolbar)]
        private Toolbar toolbar;

        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            #region Разметка

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_delete);
            Cheeseknife.Bind(this);
            SetActionBar(toolbar);
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.Title = "Удалить";

            #endregion


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