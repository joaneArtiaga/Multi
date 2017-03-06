using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Multiscreen
{
    [Activity(Label = "UserDisplayActivity")]
    public class UserDisplayActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.user_display);

            TextView name = FindViewById<TextView>(Resource.Id.etName);
            TextView date = FindViewById<TextView>(Resource.Id.etbdate);
            name.Text = UserData.Name;
            date.Text = UserData.BirthDate.ToShortDateString();

            
        }
    }
}