using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Telephony.Euicc;
using Android.Text;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.ConstraintLayout.Motion.Widget;
using Clans.Fab;
using CompEat_CuppyBreak_Initial.Resources;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Internal;
using Google.Android.Material.Snackbar;
using Java.Security;
using Java.Util.Functions;
using System;
using static Android.Bluetooth.BluetoothClass;
using static Android.Provider.Settings;
using AlertDialog = Android.App.AlertDialog;
using FloatingActionButton = Google.Android.Material.FloatingActionButton.FloatingActionButton;

namespace CompEat_CuppyBreak_Initial
{
    [Activity(Label = "Cuppy Break", Theme = "@style/AppTheme", MainLauncher = true)]

    
    public class MainActivity : AppCompatActivity 
    {
        //Default Value
        public int deftotal = 0;

        //PRICES INTEGERS
        public int price10 = 10;
        public int price15 = 15;
        public int price17 = 17;
        public int price18 = 18;
        public int price19 = 19;
        public int price20 = 20;
        public int price25 = 25;
        public int price28 = 28;
        public int price30 = 30;
        public int price45 = 45;
        public int price49 = 49;
        public int price59 = 59;
        public int price69 = 69;
        public int price79 = 79;
        public int price89 = 89;

        protected override void OnRestart()
        {
            base.OnRestart();
            EditText total = (EditText)FindViewById(Resource.Id.totalnum);
            TextView itemcounts = (TextView)FindViewById(Resource.Id.changetotal);

            //16oz
            TextView itemcount1 = (TextView)FindViewById(Resource.Id.numitemssplt);
            TextView itemcount2 = (TextView)FindViewById(Resource.Id.numitemscpn);
            TextView itemcount3 = (TextView)FindViewById(Resource.Id.numitemsamk);
            TextView itemcount4 = (TextView)FindViewById(Resource.Id.numitemsvnlt);
            TextView itemcount5 = (TextView)FindViewById(Resource.Id.numitemscrml);
            TextView itemcount6 = (TextView)FindViewById(Resource.Id.numitemsMstw);
            TextView itemcount7 = (TextView)FindViewById(Resource.Id.numitemsstlt);
            TextView itemcount8 = (TextView)FindViewById(Resource.Id.numitemschl);

            //22oz
            TextView itemcount9 = (TextView)FindViewById(Resource.Id.numitemssplt20);
            TextView itemcount10 = (TextView)FindViewById(Resource.Id.numitemscpn20);
            TextView itemcount11 = (TextView)FindViewById(Resource.Id.numitemsamk20);
            TextView itemcount12 = (TextView)FindViewById(Resource.Id.numitemsvnlt20);
            TextView itemcount13 = (TextView)FindViewById(Resource.Id.numitemscrml20);
            TextView itemcount14 = (TextView)FindViewById(Resource.Id.numitemsMstw20);
            TextView itemcount15 = (TextView)FindViewById(Resource.Id.numitemsstlt20);
            TextView itemcount16 = (TextView)FindViewById(Resource.Id.numitemschl20);

            //Add Ons
            TextView itemcount17 = (TextView)FindViewById(Resource.Id.numitemssgr);
            TextView itemcount18 = (TextView)FindViewById(Resource.Id.numitemscff);
            TextView itemcount19 = (TextView)FindViewById(Resource.Id.numitemsmlk);

            //Pastries
            TextView itemcount20 = (TextView)FindViewById(Resource.Id.numitemspdg);
            TextView itemcount21 = (TextView)FindViewById(Resource.Id.numitemsbrk);
            TextView itemcount22 = (TextView)FindViewById(Resource.Id.numitemsmkydnt);
            TextView itemcount23 = (TextView)FindViewById(Resource.Id.numitemssYbrd);
            TextView itemcount24 = (TextView)FindViewById(Resource.Id.numitemschbrd);
            TextView itemcount25 = (TextView)FindViewById(Resource.Id.numitemsbrwns);

            //Other Products
            TextView itemcount26 = (TextView)FindViewById(Resource.Id.numitemswtr10);
            TextView itemcount27 = (TextView)FindViewById(Resource.Id.numitemswtr15);
            TextView itemcount28 = (TextView)FindViewById(Resource.Id.numitemsswtr20);
            TextView itemcount29 = (TextView)FindViewById(Resource.Id.numitemsNst);
            TextView itemcount30 = (TextView)FindViewById(Resource.Id.numitemssmrt);
            TextView itemcount31 = (TextView)FindViewById(Resource.Id.numitemspps);
            TextView itemcount32 = (TextView)FindViewById(Resource.Id.numitemsrlf);
            TextView itemcount33 = (TextView)FindViewById(Resource.Id.numitemssmnmd);
            TextView itemcount34 = (TextView)FindViewById(Resource.Id.numitemscccl);
            TextView itemcount35 = (TextView)FindViewById(Resource.Id.numitemsrc);
            TextView itemcount36 = (TextView)FindViewById(Resource.Id.numitemsjcl);
            TextView itemcount37 = (TextView)FindViewById(Resource.Id.numitemsgtrd);
            TextView itemcount38 = (TextView)FindViewById(Resource.Id.numitemsyklt);

            TextView cart = (TextView)FindViewById(Resource.Id.cartcount);
            

            //RESETS ALL VALUES
            itemcount1.Text = 0.ToString();
            itemcount2.Text = 0.ToString();
            itemcount3.Text = 0.ToString();
            itemcount4.Text = 0.ToString();
            itemcount5.Text = 0.ToString();
            itemcount6.Text = 0.ToString();
            itemcount7.Text = 0.ToString();
            itemcount8.Text = 0.ToString();
            itemcount9.Text = 0.ToString();
            itemcount10.Text = 0.ToString();
            itemcount11.Text = 0.ToString();
            itemcount12.Text = 0.ToString();
            itemcount13.Text = 0.ToString();
            itemcount14.Text = 0.ToString();
            itemcount15.Text = 0.ToString();
            itemcount16.Text = 0.ToString();
            itemcount17.Text = 0.ToString();
            itemcount18.Text = 0.ToString();
            itemcount19.Text = 0.ToString();
            itemcount20.Text = 0.ToString();
            itemcount21.Text = 0.ToString();
            itemcount22.Text = 0.ToString();
            itemcount23.Text = 0.ToString();
            itemcount24.Text = 0.ToString();
            itemcount25.Text = 0.ToString();
            itemcount26.Text = 0.ToString();
            itemcount27.Text = 0.ToString();
            itemcount28.Text = 0.ToString();
            itemcount29.Text = 0.ToString();
            itemcount30.Text = 0.ToString();
            itemcount31.Text = 0.ToString();
            itemcount32.Text = 0.ToString();
            itemcount33.Text = 0.ToString();
            itemcount34.Text = 0.ToString();
            itemcount35.Text = 0.ToString();
            itemcount36.Text = 0.ToString();
            itemcount37.Text = 0.ToString();
            itemcount38.Text = 0.ToString();


            itemcounts.Text = "ALL ITEMS:";
            total.Text = 0.ToString();
            cart.Text = 0.ToString();

        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            TextView itemcounts = (TextView)FindViewById(Resource.Id.changetotal);
            

            //VIEW AND BUTTONS ID VARIABLES INSTANTIATION

            //Card variables for adding values

            //16oz
            CardView card1 = (CardView)FindViewById(Resource.Id.cardView1);
            CardView card2 = (CardView)FindViewById(Resource.Id.cardView2);
            CardView card3 = (CardView)FindViewById(Resource.Id.cardView3);
            CardView card4 = (CardView)FindViewById(Resource.Id.cardView4);
            CardView card5 = (CardView)FindViewById(Resource.Id.cardView5);
            CardView card6 = (CardView)FindViewById(Resource.Id.cardView6);
            CardView card7 = (CardView)FindViewById(Resource.Id.cardView7);
            CardView card8 = (CardView)FindViewById(Resource.Id.cardView8);

            //20oz
            CardView card9 = (CardView)FindViewById(Resource.Id.cardView9);
            CardView card10 = (CardView)FindViewById(Resource.Id.cardView10);
            CardView card11 = (CardView)FindViewById(Resource.Id.cardView11);
            CardView card12 = (CardView)FindViewById(Resource.Id.cardView12);
            CardView card13 = (CardView)FindViewById(Resource.Id.cardView13);
            CardView card14 = (CardView)FindViewById(Resource.Id.cardView14);
            CardView card15 = (CardView)FindViewById(Resource.Id.cardView15);
            CardView card16 = (CardView)FindViewById(Resource.Id.cardView16);

            //Add Ons
            CardView card17 = (CardView)FindViewById(Resource.Id.cardView17);
            CardView card18 = (CardView)FindViewById(Resource.Id.cardView18);
            CardView card19 = (CardView)FindViewById(Resource.Id.cardView19);

            //Pastries
            CardView card20 = (CardView)FindViewById(Resource.Id.cardView20);
            CardView card21 = (CardView)FindViewById(Resource.Id.cardView21);
            CardView card22 = (CardView)FindViewById(Resource.Id.cardView22);
            CardView card23 = (CardView)FindViewById(Resource.Id.cardView23);
            CardView card24 = (CardView)FindViewById(Resource.Id.cardView24);
            CardView card25 = (CardView)FindViewById(Resource.Id.cardView25);

            //Other Products
            CardView card26 = (CardView)FindViewById(Resource.Id.cardView26);
            CardView card27 = (CardView)FindViewById(Resource.Id.cardView27);
            CardView card28 = (CardView)FindViewById(Resource.Id.cardView28);
            CardView card29 = (CardView)FindViewById(Resource.Id.cardView29);
            CardView card30 = (CardView)FindViewById(Resource.Id.cardView30);
            CardView card31 = (CardView)FindViewById(Resource.Id.cardView31);
            CardView card32 = (CardView)FindViewById(Resource.Id.cardView32);
            CardView card33 = (CardView)FindViewById(Resource.Id.cardView33);
            CardView card34 = (CardView)FindViewById(Resource.Id.cardView34);
            CardView card35 = (CardView)FindViewById(Resource.Id.cardView35);
            CardView card36 = (CardView)FindViewById(Resource.Id.cardView36);
            CardView card37 = (CardView)FindViewById(Resource.Id.cardView37);
            CardView card38 = (CardView)FindViewById(Resource.Id.cardView38);

 
            //Subtract buttons

            //16oz
            ImageButton subbutton1 = (ImageButton)FindViewById(Resource.Id.lesssplt);
            ImageButton subbutton2 = (ImageButton)FindViewById(Resource.Id.lesscpn);
            ImageButton subbutton3 = (ImageButton)FindViewById(Resource.Id.lessamk);
            ImageButton subbutton4 = (ImageButton)FindViewById(Resource.Id.lessvnlt);
            ImageButton subbutton5 = (ImageButton)FindViewById(Resource.Id.lesscrml);
            ImageButton subbutton6 = (ImageButton)FindViewById(Resource.Id.lessmstw);
            ImageButton subbutton7 = (ImageButton)FindViewById(Resource.Id.lessstlt);
            ImageButton subbutton8 = (ImageButton)FindViewById(Resource.Id.lesschl);

            //20oz
            ImageButton subbutton9 = (ImageButton)FindViewById(Resource.Id.lesssplt20);
            ImageButton subbutton10 = (ImageButton)FindViewById(Resource.Id.lesscpn20);
            ImageButton subbutton11 = (ImageButton)FindViewById(Resource.Id.lessamk20);
            ImageButton subbutton12 = (ImageButton)FindViewById(Resource.Id.lessvnlt20);
            ImageButton subbutton13 = (ImageButton)FindViewById(Resource.Id.lesscrml20);
            ImageButton subbutton14 = (ImageButton)FindViewById(Resource.Id.lessmstw20);
            ImageButton subbutton15 = (ImageButton)FindViewById(Resource.Id.lessstlt20);
            ImageButton subbutton16 = (ImageButton)FindViewById(Resource.Id.lesschl20);

            //Add ons
            ImageButton subbutton17 = (ImageButton)FindViewById(Resource.Id.lesssgr);
            ImageButton subbutton18 = (ImageButton)FindViewById(Resource.Id.lesscff);
            ImageButton subbutton19 = (ImageButton)FindViewById(Resource.Id.lessmlk);

            //Pastries
            ImageButton subbutton20 = (ImageButton)FindViewById(Resource.Id.lesspdg);
            ImageButton subbutton21 = (ImageButton)FindViewById(Resource.Id.lessbrk);
            ImageButton subbutton22 = (ImageButton)FindViewById(Resource.Id.lessmkydnt);
            ImageButton subbutton23 = (ImageButton)FindViewById(Resource.Id.lessybrd);
            ImageButton subbutton24 = (ImageButton)FindViewById(Resource.Id.lesschbrd);
            ImageButton subbutton25 = (ImageButton)FindViewById(Resource.Id.lessbrwns);

            //Others
            ImageButton subbutton26 = (ImageButton)FindViewById(Resource.Id.lesswtr10);
            ImageButton subbutton27 = (ImageButton)FindViewById(Resource.Id.lesswtr15);
            ImageButton subbutton28 = (ImageButton)FindViewById(Resource.Id.lesswtr20);
            ImageButton subbutton29 = (ImageButton)FindViewById(Resource.Id.lessnst);
            ImageButton subbutton30 = (ImageButton)FindViewById(Resource.Id.lesssmrt);
            ImageButton subbutton31 = (ImageButton)FindViewById(Resource.Id.lesspps);
            ImageButton subbutton32 = (ImageButton)FindViewById(Resource.Id.lessrlf);
            ImageButton subbutton33 = (ImageButton)FindViewById(Resource.Id.lessmnmd);
            ImageButton subbutton34 = (ImageButton)FindViewById(Resource.Id.lesscccl);
            ImageButton subbutton35 = (ImageButton)FindViewById(Resource.Id.lessrc);
            ImageButton subbutton36 = (ImageButton)FindViewById(Resource.Id.lessjcl);
            ImageButton subbutton37 = (ImageButton)FindViewById(Resource.Id.lessgtrd);
            ImageButton subbutton38 = (ImageButton)FindViewById(Resource.Id.lessyklt);


            //Number Values

            //16oz
            TextView itemcount1 = (TextView)FindViewById(Resource.Id.numitemssplt);
            TextView itemcount2 = (TextView)FindViewById(Resource.Id.numitemscpn);
            TextView itemcount3 = (TextView)FindViewById(Resource.Id.numitemsamk);
            TextView itemcount4 = (TextView)FindViewById(Resource.Id.numitemsvnlt);
            TextView itemcount5 = (TextView)FindViewById(Resource.Id.numitemscrml);
            TextView itemcount6 = (TextView)FindViewById(Resource.Id.numitemsMstw);
            TextView itemcount7 = (TextView)FindViewById(Resource.Id.numitemsstlt);
            TextView itemcount8 = (TextView)FindViewById(Resource.Id.numitemschl);
            
            //22oz
            TextView itemcount9 = (TextView)FindViewById(Resource.Id.numitemssplt20);
            TextView itemcount10 = (TextView)FindViewById(Resource.Id.numitemscpn20);
            TextView itemcount11 = (TextView)FindViewById(Resource.Id.numitemsamk20);
            TextView itemcount12 = (TextView)FindViewById(Resource.Id.numitemsvnlt20);
            TextView itemcount13 = (TextView)FindViewById(Resource.Id.numitemscrml20);
            TextView itemcount14 = (TextView)FindViewById(Resource.Id.numitemsMstw20);
            TextView itemcount15 = (TextView)FindViewById(Resource.Id.numitemsstlt20);
            TextView itemcount16 = (TextView)FindViewById(Resource.Id.numitemschl20);

            //Add Ons
            TextView itemcount17 = (TextView)FindViewById(Resource.Id.numitemssgr);
            TextView itemcount18 = (TextView)FindViewById(Resource.Id.numitemscff);
            TextView itemcount19 = (TextView)FindViewById(Resource.Id.numitemsmlk);

            //Pastries
            TextView itemcount20 = (TextView)FindViewById(Resource.Id.numitemspdg);
            TextView itemcount21 = (TextView)FindViewById(Resource.Id.numitemsbrk);
            TextView itemcount22 = (TextView)FindViewById(Resource.Id.numitemsmkydnt);
            TextView itemcount23 = (TextView)FindViewById(Resource.Id.numitemssYbrd);
            TextView itemcount24 = (TextView)FindViewById(Resource.Id.numitemschbrd);
            TextView itemcount25 = (TextView)FindViewById(Resource.Id.numitemsbrwns);

            //Other Products
            TextView itemcount26 = (TextView)FindViewById(Resource.Id.numitemswtr10);
            TextView itemcount27 = (TextView)FindViewById(Resource.Id.numitemswtr15);
            TextView itemcount28 = (TextView)FindViewById(Resource.Id.numitemsswtr20);
            TextView itemcount29 = (TextView)FindViewById(Resource.Id.numitemsNst);
            TextView itemcount30 = (TextView)FindViewById(Resource.Id.numitemssmrt);
            TextView itemcount31 = (TextView)FindViewById(Resource.Id.numitemspps);
            TextView itemcount32 = (TextView)FindViewById(Resource.Id.numitemsrlf);
            TextView itemcount33 = (TextView)FindViewById(Resource.Id.numitemssmnmd);
            TextView itemcount34 = (TextView)FindViewById(Resource.Id.numitemscccl);
            TextView itemcount35 = (TextView)FindViewById(Resource.Id.numitemsrc);
            TextView itemcount36 = (TextView)FindViewById(Resource.Id.numitemsjcl);
            TextView itemcount37 = (TextView)FindViewById(Resource.Id.numitemsgtrd);
            TextView itemcount38 = (TextView)FindViewById(Resource.Id.numitemsyklt);
            

            //ITEM NAMES

            //16oz
            TextView itemname1 = (TextView)FindViewById(Resource.Id.spl);
            TextView itemname2 = (TextView)FindViewById(Resource.Id.cpn);
            TextView itemname3 = (TextView)FindViewById(Resource.Id.amk);
            TextView itemname4 = (TextView)FindViewById(Resource.Id.vnlt);
            TextView itemname5 = (TextView)FindViewById(Resource.Id.crml);

            //Sweet Beverage
            TextView itemname6 = (TextView)FindViewById(Resource.Id.mstw);
            TextView itemname7 = (TextView)FindViewById(Resource.Id.stlt);
            TextView itemname8 = (TextView)FindViewById(Resource.Id.chl);

            //22oz
            TextView itemname9 = (TextView)FindViewById(Resource.Id.spl20);
            TextView itemname10 = (TextView)FindViewById(Resource.Id.cpn20);
            TextView itemname11 = (TextView)FindViewById(Resource.Id.amk20);
            TextView itemname12 = (TextView)FindViewById(Resource.Id.vnlt20);
            TextView itemname13 = (TextView)FindViewById(Resource.Id.crml20);

            //Sweet Beverage 20oz
            TextView itemname14 = (TextView)FindViewById(Resource.Id.mstw20);
            TextView itemname15 = (TextView)FindViewById(Resource.Id.stlt20);
            TextView itemname16 = (TextView)FindViewById(Resource.Id.chl20);

            //Add Ons
            TextView itemname17 = (TextView)FindViewById(Resource.Id.sgr);
            TextView itemname18 = (TextView)FindViewById(Resource.Id.cff);
            TextView itemname19 = (TextView)FindViewById(Resource.Id.mlk);

            //Pastries
            TextView itemname20 = (TextView)FindViewById(Resource.Id.pdg);
            TextView itemname21 = (TextView)FindViewById(Resource.Id.brk);
            TextView itemname22 = (TextView)FindViewById(Resource.Id.mkydnt);
            TextView itemname23 = (TextView)FindViewById(Resource.Id.ybrd);
            TextView itemname24 = (TextView)FindViewById(Resource.Id.chbrd);
            TextView itemname25 = (TextView)FindViewById(Resource.Id.brwns);

            //Other
            TextView itemname26 = (TextView)FindViewById(Resource.Id.wtr10);
            TextView itemname27 = (TextView)FindViewById(Resource.Id.wtr15);
            TextView itemname28 = (TextView)FindViewById(Resource.Id.wtr20);
            TextView itemname29 = (TextView)FindViewById(Resource.Id.nst);
            TextView itemname30 = (TextView)FindViewById(Resource.Id.smrt);
            TextView itemname31 = (TextView)FindViewById(Resource.Id.pps);
            TextView itemname32 = (TextView)FindViewById(Resource.Id.rlf);
            TextView itemname33 = (TextView)FindViewById(Resource.Id.mnmd);
            TextView itemname34 = (TextView)FindViewById(Resource.Id.cccl);
            TextView itemname35 = (TextView)FindViewById(Resource.Id.rc);
            TextView itemname36 = (TextView)FindViewById(Resource.Id.jcl);
            TextView itemname37 = (TextView)FindViewById(Resource.Id.gtrd);
            TextView itemname38 = (TextView)FindViewById(Resource.Id.yklt);


            //Total number to display in receipt activity
            EditText total = (EditText)FindViewById(Resource.Id.totalnum);

            FloatingActionButton computebtn = (FloatingActionButton)FindViewById(Resource.Id.compute);


            //Cart Text View
            TextView cart = (TextView)FindViewById(Resource.Id.cartcount);
            ImageView carticon = (ImageView)FindViewById(Resource.Id.carticon);

            //CLICK LISTENER FOR COMPUTE BUTTON
            computebtn.Click += (s, e) =>
            {

                String gltotal = total.Text.ToString();
                int gltotalconverted = Convert.ToInt32(gltotal);

                if (gltotalconverted == 0)
                {
                    Snackbar snackbar = (Snackbar)Snackbar.Make(computebtn, "Please add an Item", Snackbar.LengthIndefinite).SetDuration(1000);
                    snackbar.Show();
                } else {
                    Intent i = new Intent(this, typeof(calculator));

                    Bundle bundle = new Bundle();

                    checktotal(itemcount1, itemname1);
                    checktotal(itemcount2, itemname2);
                    checktotal(itemcount3, itemname3);
                    checktotal(itemcount4, itemname4);
                    checktotal(itemcount5, itemname5);
                    checktotal(itemcount6, itemname6);
                    checktotal(itemcount7, itemname7);
                    checktotal(itemcount8, itemname8);
                    checktotal(itemcount9, itemname9);
                    checktotal(itemcount10, itemname10);
                    checktotal(itemcount11, itemname11);
                    checktotal(itemcount12, itemname12);
                    checktotal(itemcount13, itemname13);
                    checktotal(itemcount14, itemname14);
                    checktotal(itemcount15, itemname15);
                    checktotal(itemcount16, itemname16);
                    checktotal(itemcount17, itemname17);
                    checktotal(itemcount18, itemname18);
                    checktotal(itemcount19, itemname19);
                    checktotal(itemcount20, itemname20);
                    checktotal(itemcount21, itemname21);
                    checktotal(itemcount22, itemname22);
                    checktotal(itemcount23, itemname23);
                    checktotal(itemcount24, itemname24);
                    checktotal(itemcount25, itemname25);
                    checktotal(itemcount26, itemname26);
                    checktotal(itemcount27, itemname27);
                    checktotal(itemcount28, itemname28);
                    checktotal(itemcount29, itemname29);
                    checktotal(itemcount30, itemname30);
                    checktotal(itemcount31, itemname31);
                    checktotal(itemcount32, itemname32);
                    checktotal(itemcount33, itemname33);
                    checktotal(itemcount34, itemname34);
                    checktotal(itemcount35, itemname35);
                    checktotal(itemcount36, itemname36);
                    checktotal(itemcount37, itemname37);
                    checktotal(itemcount38, itemname38);

                    String itemlist = itemcounts.Text.ToString();

                    bundle.PutString("globaltotal", gltotal);
                    bundle.PutString("allitems", itemlist);

                    i.PutExtras(bundle);

                    StartActivity(i);
                }
                
            };
            
            //CLICK LISTENERS FOR SUBTRACT BUTTONS

            //Coffee 16oz
            subbutton1.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price59, inivalue, itemcount1);
                dectotal(itemcount1);

                removesub(subbutton1, itemcount1);
            };

            subbutton2.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price59, inivalue, itemcount2);
                dectotal(itemcount2);

                removesub(subbutton2, itemcount2);
            };

            subbutton3.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price49, inivalue, itemcount3);
                dectotal(itemcount3);

                removesub(subbutton3, itemcount3);
            };

            subbutton4.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price59, inivalue, itemcount4);
                dectotal(itemcount4);

                removesub(subbutton4, itemcount4);
            };

            subbutton5.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price69, inivalue, itemcount5);
                dectotal(itemcount5);

                removesub(subbutton5, itemcount5);
            };

            //Sweet Beverage 16 oz
            subbutton6.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price49, inivalue, itemcount6);
                dectotal(itemcount6);

                removesub(subbutton6, itemcount6);
            };

            subbutton7.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price59, inivalue, itemcount7);
                dectotal(itemcount7);

                removesub(subbutton7, itemcount7);
            };

            subbutton8.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price49, inivalue, itemcount8);
                dectotal(itemcount8);

                removesub(subbutton8, itemcount8);
            };

            //Coffee 20oz 
            subbutton9.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price79, inivalue, itemcount9);
                dectotal(itemcount9);

                removesub(subbutton9, itemcount9);
            };

            subbutton10.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price79, inivalue, itemcount10);
                dectotal(itemcount10);

                removesub(subbutton10, itemcount10);
            };

            subbutton11.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price79, inivalue, itemcount11);
                dectotal(itemcount11);

                removesub(subbutton11, itemcount11);
            };

            subbutton12.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price79, inivalue, itemcount12);
                dectotal(itemcount12);

                removesub(subbutton12, itemcount12);
            };

            subbutton13.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price89, inivalue, itemcount13);
                dectotal(itemcount13);

                removesub(subbutton13, itemcount13);
            };

            //Sweet Beverage 20oz
            subbutton14.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price69, inivalue, itemcount14);
                dectotal(itemcount14);

                removesub(subbutton14, itemcount14);
            };

            subbutton15.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price79, inivalue, itemcount15);
                dectotal(itemcount15);

                removesub(subbutton15, itemcount15);
            };

            subbutton16.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price69, inivalue, itemcount16);
                dectotal(itemcount16);

                removesub(subbutton16, itemcount16);
            };


            //Add Ons
            subbutton17.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price10, inivalue, itemcount17);
                dectotal(itemcount17);

                removesub(subbutton17, itemcount17);
            };

            subbutton18.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price10, inivalue, itemcount18);
                dectotal(itemcount18);

                removesub(subbutton18, itemcount18);
            };

            subbutton19.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price10, inivalue, itemcount19);
                dectotal(itemcount19);

                removesub(subbutton19, itemcount19);
            };


            //Pastries
            subbutton20.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price15, inivalue, itemcount20);
                dectotal(itemcount20);

                removesub(subbutton20, itemcount20);
            };

            subbutton21.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price10, inivalue, itemcount21);
                dectotal(itemcount21);

                removesub(subbutton21, itemcount21);
            };

            subbutton22.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price15, inivalue, itemcount22);
                dectotal(itemcount22);

                removesub(subbutton22, itemcount22);
            };

            subbutton23.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price20, inivalue, itemcount23);
                dectotal(itemcount23);

                removesub(subbutton23, itemcount23);
            };

            subbutton24.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price20, inivalue, itemcount24);
                dectotal(itemcount24);

                removesub(subbutton24, itemcount24);
            };

            subbutton25.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price25, inivalue, itemcount25);
                dectotal(itemcount25);

                removesub(subbutton25, itemcount25);
            };

            //Other Products
            subbutton26.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price10, inivalue, itemcount26);
                dectotal(itemcount26);

                removesub(subbutton26, itemcount26);
            };

            subbutton27.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price15, inivalue, itemcount27);
                dectotal(itemcount27);

                removesub(subbutton27, itemcount27);
            };

            subbutton28.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price20, inivalue, itemcount28);
                dectotal(itemcount28);

                removesub(subbutton28, itemcount28);
            };

            subbutton29.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price25, inivalue, itemcount29);
                dectotal(itemcount29);

                removesub(subbutton29, itemcount29);
            };

            subbutton30.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price30, inivalue, itemcount30);
                dectotal(itemcount30);

                removesub(subbutton30, itemcount30);
            };

            subbutton31.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price18, inivalue, itemcount31);
                dectotal(itemcount31);

                removesub(subbutton31, itemcount31);
            };

            subbutton32.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price28, inivalue, itemcount32);
                dectotal(itemcount32);

                removesub(subbutton32, itemcount32);
            };

            subbutton33.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price19, inivalue, itemcount33);
                dectotal(itemcount33);

                removesub(subbutton33, itemcount33);
            };

            subbutton34.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price20, inivalue, itemcount34);
                dectotal(itemcount34);

                removesub(subbutton34, itemcount34);
            };

            subbutton35.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price19, inivalue, itemcount35);
                dectotal(itemcount35);

                removesub(subbutton35, itemcount35);
            };

            subbutton36.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price17, inivalue, itemcount36);
                dectotal(itemcount36);

                removesub(subbutton36, itemcount36);
            };

            subbutton37.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price45, inivalue, itemcount37);
                dectotal(itemcount37);

                removesub(subbutton37, itemcount37);
            };

            subbutton38.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                subvalue(price15, inivalue, itemcount38);
                dectotal(itemcount38);

                removesub(subbutton38, itemcount38);
            };

            //CLICK LISTENERS FOR CARDS

            //Coffee 16oz
            card1.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price59, inivalue);
                inctotal(itemcount1);

                displaysub(subbutton1, itemcount1);
                
            };

            card2.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price59, inivalue);
                inctotal(itemcount2);

                displaysub(subbutton2, itemcount2);
            };

            card3.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price49, inivalue);
                inctotal(itemcount3);

                displaysub(subbutton3, itemcount3);
            };

            card4.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price59, inivalue);
                inctotal(itemcount4);

                displaysub(subbutton4, itemcount4);
            };

            card5.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price69, inivalue);
                inctotal(itemcount5);

                displaysub(subbutton5, itemcount5);
            };

            //Sweet Beverage 16 oz
            card6.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price49, inivalue);
                inctotal(itemcount6);

                displaysub(subbutton6, itemcount6);
            };

            card7.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price59, inivalue);
                inctotal(itemcount7);

                displaysub(subbutton7, itemcount7);
            };

            card8.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price49, inivalue);
                inctotal(itemcount8);

                displaysub(subbutton8, itemcount8);
            };

            //Coffee 20oz 
            card9.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price79, inivalue);
                inctotal(itemcount9);

                displaysub(subbutton9, itemcount9);
            };

            card10.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price79, inivalue);
                inctotal(itemcount10);

                displaysub(subbutton10, itemcount10);
            };

            card11.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price79, inivalue);
                inctotal(itemcount11);

                displaysub(subbutton11, itemcount11);
            };

            card12.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price79, inivalue);
                inctotal(itemcount12);

                displaysub(subbutton12, itemcount12);
            };

            card13.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price89, inivalue);
                inctotal(itemcount13);

                displaysub(subbutton13, itemcount13);
            };


            //Sweet Beverage 20oz
            card14.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price69, inivalue);
                inctotal(itemcount14);

                displaysub(subbutton14, itemcount14);
            };

            card15.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price79, inivalue);
                inctotal(itemcount15);

                displaysub(subbutton15, itemcount15);
            };

            card16.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price69, inivalue);
                inctotal(itemcount16);

                displaysub(subbutton16, itemcount16);
            };


            //Add Ons
            card17.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price10, inivalue);
                inctotal(itemcount17);

                displaysub(subbutton17, itemcount17);
            };

            card18.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price10, inivalue);
                inctotal(itemcount18);

                displaysub(subbutton18, itemcount18);
            };

            card19.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price10, inivalue);
                inctotal(itemcount19);

                displaysub(subbutton19, itemcount19);
            };


            //Pastries
            card20.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price15, inivalue);
                inctotal(itemcount20);

                displaysub(subbutton20, itemcount20);
            };

            card21.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price10, inivalue);
                inctotal(itemcount21);

                displaysub(subbutton21, itemcount21);
            };

            card22.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price15, inivalue);
                inctotal(itemcount22);

                displaysub(subbutton22, itemcount22);
            };

            card23.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price20, inivalue);
                inctotal(itemcount23);

                displaysub(subbutton23, itemcount23);
            };

            card24.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price20, inivalue);
                inctotal(itemcount24);

                displaysub(subbutton24, itemcount24);
            };

            card25.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price25, inivalue);
                inctotal(itemcount25);

                displaysub(subbutton25, itemcount25);
            };

            //Other Products
            card26.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price10, inivalue);
                inctotal(itemcount26);

                displaysub(subbutton26, itemcount26);
            };

            card27.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price15, inivalue);
                inctotal(itemcount27);

                displaysub(subbutton27, itemcount27);
            };

            card28.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price20, inivalue);
                inctotal(itemcount28);

                displaysub(subbutton28, itemcount28);
            };

            card29.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price25, inivalue);
                inctotal(itemcount29);

                displaysub(subbutton29, itemcount29);
            };

            card30.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price30, inivalue);
                inctotal(itemcount30);

                displaysub(subbutton30, itemcount30);
            };

            card31.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price18, inivalue);
                inctotal(itemcount31);

                displaysub(subbutton31, itemcount31);
            };

            card32.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price28, inivalue);
                inctotal(itemcount32);

                displaysub(subbutton32, itemcount32);
            };

            card33.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price19, inivalue);
                inctotal(itemcount33);

                displaysub(subbutton33, itemcount33);
            };

            card34.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price20, inivalue);
                inctotal(itemcount34);

                displaysub(subbutton34, itemcount34);
            };

            card35.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price19, inivalue);
                inctotal(itemcount35);

                displaysub(subbutton35, itemcount35);
            };

            card36.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price17, inivalue);
                inctotal(itemcount36);

                displaysub(subbutton36, itemcount36);
            };

            card37.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price45, inivalue);
                inctotal(itemcount37);

                displaysub(subbutton37, itemcount37);
            };

            card38.Click += (s, e) =>
            {
                var inivalue = total.Text.ToString();
                addvalue(price15, inivalue);
                inctotal(itemcount38);

                displaysub(subbutton38, itemcount38);
            };

            carticon.Click += (s, e) =>
            {
                displayitems();
            };


            //METHODS AND ALGORITHMS

            //Adds price per product
            void addvalue(int x, String y) {
                
                //Gets values from clicklistener
                int addedvalue = x;
                string initvalue = y;

                //Converts String value of EditText Field to Integer
                int convertedvalue = Convert.ToInt32(initvalue);

                //Performs operation
                int finalvalue = convertedvalue + addedvalue;

                total.Text = finalvalue.ToString();

                
            }

            //Subtracts price per product
            void subvalue(int x, String y, TextView z)
            {
                //Gets values from clicklistener and stores to local variable
                int addedvalue = x;
                string initvalue = y;
                TextView itemcountview = z;

                var itemcount = itemcounts.Text;
                int convertedvalue = Convert.ToInt32(initvalue);

                String totalitemcount = z.Text.ToString();

                int totalitemcountconverted = Convert.ToInt32(totalitemcount);

                int finalvalue = convertedvalue - addedvalue;

                //Conditional statement that prevents negative values in Final Value
                

                if(totalitemcountconverted > 0) {
                    if (finalvalue > 0)
                    {
                        total.Text = finalvalue.ToString();
                    }
                    else if (finalvalue < 0 || convertedvalue == 0)
                    {
                        total.Text = deftotal.ToString();
                    }
                    else
                    {
                        total.Text = deftotal.ToString();
                    }
                } else
                {
                    int nonfinalvalue = convertedvalue - deftotal;

                    total.Text = nonfinalvalue.ToString();
                }

         
            }

            //Adds 1 to item count every click per Product
            void inctotal(TextView x)
            {
                //Gets TextView ID from Click listener and Parses the Value into local variable
                TextView itemcountfinal = x;
                var convertedvalue = x.Text.ToString();

                //Converts the String Value to Integer and Increments
                int itemcount = Convert.ToInt32(convertedvalue);


                itemcount++;

                //Changes the Value of Item Count TextView
                x.Text = itemcount.ToString();


                var cartcountinit = cart.Text.ToString();

                int cartcountconverted = Convert.ToInt32(cartcountinit);

                cartcountconverted++;


                cart.Text = cartcountconverted.ToString();

                if (itemcount == 1)
                {
                    Snackbar snackbar = (Snackbar)Snackbar.Make(computebtn, "Item Added!", Snackbar.LengthIndefinite).SetDuration(1000);
                    snackbar.Show();
                }
                
            }

            //Subtracts 1 from item count per product
            void dectotal(TextView x)
            {
                //Gets TextView ID from Click Listener and Parses the Value into local variable
                TextView itemcountfinal = x;
                var convertedvalue = x.Text.ToString();

                int itemcount = Convert.ToInt32(convertedvalue);



                var cartcountinit = cart.Text.ToString();

                int itemcountconverted = Convert.ToInt32(cartcountinit);


                //Conditional statement checks if itemcount is already 0 to prevent negative values
                if (itemcount == 0 || itemcount < 0)
                {
                    x.Text = deftotal.ToString();
                    Toast.MakeText(this, "No more items to deduct", ToastLength.Short).Show();
                }
                else
                {
                    itemcount--;
                    itemcountconverted--;
                    x.Text = itemcount.ToString();
                    cart.Text = itemcountconverted.ToString();

                }
            }

            void checktotal(TextView x, TextView y) {
                TextView itemcounted = x;
                TextView itemname = y;

                var finalitem = x.Text.ToString();
                String itemlist = y.Text.ToString();
                int itemfinalcount = Convert.ToInt32(finalitem);

                if (itemfinalcount > 0)
                {
                    String inittext = itemcounts.Text.ToString();
                    itemcounts.Text = inittext +"\n" + itemfinalcount.ToString() + " " + itemlist;
                } 

            }

            void displayitems()
            {
                checktotal(itemcount1, itemname1);
                checktotal(itemcount2, itemname2);
                checktotal(itemcount3, itemname3);
                checktotal(itemcount4, itemname4);
                checktotal(itemcount5, itemname5);
                checktotal(itemcount6, itemname6);
                checktotal(itemcount7, itemname7);
                checktotal(itemcount8, itemname8);
                checktotal(itemcount9, itemname9);
                checktotal(itemcount10, itemname10);
                checktotal(itemcount11, itemname11);
                checktotal(itemcount12, itemname12);
                checktotal(itemcount13, itemname13);
                checktotal(itemcount14, itemname14);
                checktotal(itemcount15, itemname15);
                checktotal(itemcount16, itemname16);
                checktotal(itemcount17, itemname17);
                checktotal(itemcount18, itemname18);
                checktotal(itemcount19, itemname19);
                checktotal(itemcount20, itemname20);
                checktotal(itemcount21, itemname21);
                checktotal(itemcount22, itemname22);
                checktotal(itemcount23, itemname23);
                checktotal(itemcount24, itemname24);
                checktotal(itemcount25, itemname25);
                checktotal(itemcount26, itemname26);
                checktotal(itemcount27, itemname27);
                checktotal(itemcount28, itemname28);
                checktotal(itemcount29, itemname29);
                checktotal(itemcount30, itemname30);
                checktotal(itemcount31, itemname31);
                checktotal(itemcount32, itemname32);
                checktotal(itemcount33, itemname33);
                checktotal(itemcount34, itemname34);
                checktotal(itemcount35, itemname35);
                checktotal(itemcount36, itemname36);
                checktotal(itemcount37, itemname37);
                checktotal(itemcount38, itemname38);

                String cartlist = itemcounts.Text.ToString() + "\n" + "TOTAL: ₱" + total.Text.ToString();
                String noitems = " " + "\n" + "NO ITEMS IN CART";

                if (itemcounts.Text.ToString().Equals("ALL ITEMS:") || itemcounts.Text.ToString().Equals("ITEMS:") || total.Text.ToString().Equals("0"))
                {
                    var dialog = new AlertDialog.Builder(this);

                    AlertDialog alert = dialog.Create();

                    alert.SetTitle("Items in Cart:");
                    alert.SetMessage(noitems);
                    alert.Show();

                    itemcounts.Text = "ALL ITEMS:";
                } else
                {
                    var dialog = new AlertDialog.Builder(this);

                    AlertDialog alert = dialog.Create();

                    alert.SetTitle("Items in Cart:");
                    alert.SetMessage(cartlist);
                    alert.Show();

                    itemcounts.Text = "ALL ITEMS:";
                }

                
            }

            void displaysub(ImageButton x, TextView y)
            {
                ImageButton subbtn = x;
                TextView itemcount = y;

                String itemcountstringed = y.Text.ToString();

                int itemcountconverted = Convert.ToInt32(itemcountstringed);


                if (itemcountconverted > 0)
                {
                    x.Visibility = ViewStates.Visible;
                } else
                {
                    x.Visibility = ViewStates.Invisible;
                }
                
            }

            void removesub(ImageButton x, TextView y)
            {
                ImageButton subbtn = x;
                TextView itemcount = y;

                String itemcountstringed = y.Text.ToString();

                int itemcountconverted = Convert.ToInt32(itemcountstringed);

                if (itemcountconverted == 0 || itemcountconverted < 0)
                {
                    x.Visibility = ViewStates.Invisible;
                } 

            }

            //Computes the Total Change of Customer
            /*void compchange()
            {
                //Gets the values from EditText Fields of Total Amount and Amount Received
                var totalamount = total.Text.ToString();
                var received = amount.Text.ToString();

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


                changetotal.Text = "CHANGE: \nInsufficient \nAmount";


                //Checks if result of operation is less than 0 or equal to 0 to avoid negative values
                //Checks for how much needs to be paid if customer total paid price insufficient
                if (finalchange < 0) {
                    int shortprice = totalconverted - receivedconverted;
                    changetotal.Text = "CHANGE: \nInsufficient \nAmount" + "\n\nPlease add \n₱" + shortprice.ToString();
                } else if (finalchange == 0) {
                    changetotal.Text = "CHANGE: \nN/A";
                } else {
                    changetotal.Text = finaltext;
                }
            }*/
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
