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

namespace CompEat_CuppyBreak_Initial.Resources
{
    [Activity(Label = "Activity1")]
    public class finalization : Activity
    {
        protected override void OnRestart()
        {
            base.OnRestart();
            TextView allitems = (TextView)FindViewById(Resource.Id.frontorders);
            TextView total = (TextView)FindViewById(Resource.Id.fronttotal);
            TextView change = (TextView)FindViewById(Resource.Id.frontchange);
            TextView orderid = (TextView)FindViewById(Resource.Id.ordercode);

            Random random = new Random();

            int initnum = random.Next(1, 100);

            String str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int size = 5;

            // Initializing the empty string
            String ran = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting an index randomly
                int x = random.Next(26);

                // Appending the character at the 
                // index to the random string.
                ran = ran + str[x];
            }


            String finalid = ran.ToString() + initnum.ToString();

            total.Text = " ";
            allitems.Text = "No Items";
            change.Text = " ";
            orderid.Text = "Order ID:\nCart Empty\n\nPlease Place New Order";
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.finalizati);

            TextView allitems = (TextView)FindViewById(Resource.Id.frontorders);
            TextView total = (TextView)FindViewById(Resource.Id.fronttotal);
            TextView change = (TextView)FindViewById(Resource.Id.frontchange);
            TextView orderid = (TextView)FindViewById(Resource.Id.ordercode);

            Button backbutton = (Button)FindViewById(Resource.Id.toCalcu);
            Button placeorder = (Button)FindViewById(Resource.Id.placeorder);

            String passdata2 = Intent.GetStringExtra("finaltotal").ToString();
            String passdata3 = Intent.GetStringExtra("finalchange").ToString();
            String passdata4 = Intent.GetStringExtra("allitemsfinalized").ToString();
            // Create your application here
            total.Text = passdata2;
            change.Text = passdata3;
            allitems.Text = passdata4;

            Random random = new Random();

            int initnum = random.Next(1, 100);

            String str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int size = 5;

            // Initializing the empty string
            String ran = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting an index randomly
                int x = random.Next(26);


                ran = ran + str[x];
            }
            String finalid = ran.ToString() + initnum.ToString();
            orderid.Text = "\n Order ID:" + finalid.ToString();

            placeorder.Click += (source, e) =>
            {

                String date = DateTime.Now.ToString("MMM.dd.yy hh:mm tt");

                String orderidemail = orderid.Text.ToString() + "\n(Please present Order ID upon Pick up)";
                String allitemsemail = allitems.Text.ToString() + "\n\n\n" + "ENTER FULL NAME:" + "\n\n" + "ENTER CONTACT NUMBER:" + "\n\n"+ "NOTE FOR PICK UP (TIME AND ADDITIONAL NOTES):" + "\n\n" + "Note: Order will be discarded if fields are empty and/or Format is changed" + "\n\nTOTAL: " + total.Text.ToString() + "\n\nORDERED:\n" + date; ;
                

                var email = new Intent(Intent.ActionSend);

                email.PutExtra(Intent.ExtraEmail, new String[]
                {
                    "cuppybreakorders@gmail.com"
                });
                email.PutExtra(Intent.ExtraSubject, String.Join("", orderidemail));
                email.PutExtra(Intent.ExtraText, String.Join("", allitemsemail));

                email.SetType("message/rfc822");


                StartActivity(Intent.CreateChooser(email, "Email to Place Order"));

            };

            backbutton.Click += (source, e) =>
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }
    }
}