using Android.Accounts;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompEat_CuppyBreak_Initial.Resources
{
    [Activity(Label = "Activity1")]
    public class calculator : Activity
    {
        protected override void OnRestart()
        {
            base.OnRestart();
            TextView items = (TextView)FindViewById(Resource.Id.items);
            TextView totalprice = (TextView)FindViewById(Resource.Id.price);
            TextView totalchange = (TextView)FindViewById(Resource.Id.change);

            items.Text = "No Items";
            totalprice.Text = "N/A";
            totalchange.Text = "N/A";
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.calcu);
            Bundle bundle = new Bundle();

            TextView totalprice = (TextView)FindViewById(Resource.Id.price);
            TextView totalchange = (TextView)FindViewById(Resource.Id.change);
            TextView items = (TextView)FindViewById(Resource.Id.items);
            Button calculate = (Button)FindViewById(Resource.Id.tofinal);
            Button compute = (Button)FindViewById(Resource.Id.compute);
            Button clear = (Button)FindViewById(Resource.Id.clear);
            EditText rcv = (EditText)FindViewById(Resource.Id.received);

            String passdata1 = Intent.GetStringExtra("globaltotal").ToString();
            String passdata2 = Intent.GetStringExtra("allitems").ToString();

            totalprice.Text = "₱" + passdata1;
            items.Text = passdata2;

            clear.Click += (source, e) => {
                totalchange.Text = "Change:";
            };

            compute.Click += (source, e) => {
                compchange();
            };

            calculate.Click += (source, e) => {
                String ftotal = totalprice.Text.ToString();
                String fchange = totalchange.Text.ToString();
                String allitemfinal = items.Text.ToString();
                Intent i = new Intent(this, typeof(finalization));

                Bundle bundle = new Bundle();

                bundle.PutString("finaltotal", ftotal);
                bundle.PutString("finalchange", fchange);
                bundle.PutString("allitemsfinalized", allitemfinal);

                i.PutExtras(bundle);

                StartActivity(i);
            };


            // Create your application here
            void compchange()
            {
                //Gets the values from EditText Fields of Total Amount and Amount Received
                var totalamount = passdata1;
                var received = rcv.Text.ToString();

                //Checks if Edittext String is equal to Null, values it as 0 to avoid Exceptions
                if (totalamount.Equals("") || received.Equals("") || totalamount.Equals(null) || received.Equals(null))
                {
                    totalamount = 0.ToString();
                    received = 0.ToString();
                }

                //Converts values to Integers
                int totalconverted = Convert.ToInt32(totalamount);
                int receivedconverted = Convert.ToInt32(received);

                int finalchange = receivedconverted - totalconverted;

                var finaltext = "CHANGE: \n₱" + finalchange.ToString();


                totalchange.Text = "CHANGE: \nInsufficient \nAmount";


                //Checks if result of operation is less than 0 or equal to 0 to avoid negative values
                //Checks for how much needs to be paid if customer total paid price insufficient
                if (finalchange < 0)
                {
                    int shortprice = totalconverted - receivedconverted;
                    totalchange.Text = "CHANGE: \nInsufficient \nAmount" + "\n\nPlease add \n₱" + shortprice.ToString();
                }
                else if (finalchange == 0)
                {
                    totalchange.Text = "CHANGE: \nN/A";
                }
                else
                {
                    totalchange.Text = finaltext;
                }
            }

        }
    }
}