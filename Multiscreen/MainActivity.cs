using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace Multiscreen
{
    [Activity(Label = "Multiscreen", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button btn = FindViewById<Button>(Resource.Id.submitBtn);
            btn.Click += (sender, e) => {
                EditText name = FindViewById<EditText>(Resource.Id.etName);
                UserData.Name = name.Text;

                CalendarView date = FindViewById<CalendarView>(Resource.Id.birthDate);

                date.DateChange += CalendarOnDateChange;
                var intent = new Intent(this, typeof(UserDisplayActivity));
                StartActivity(intent);
            };
        }

        private void CalendarOnDateChange(object sender, CalendarView.DateChangeEventArgs args) {
            UserData.BirthDate = new DateTime(args.Year, args.Month, args.DayOfMonth );
        }
    }
}

