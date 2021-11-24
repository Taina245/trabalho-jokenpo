using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Webkit;
using Android.Widget;
using Android.Content;

namespace dadosEntreTelas
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtNome, txtCategoria;
        Button btnOk;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            txtNome = FindViewById<EditText>(Resource.Id.txtNome);
            txtCategoria = FindViewById<EditText>(Resource.Id.txtCategoria);
            btnOk = FindViewById<Button>(Resource.Id.btnOK);

            btnOk.Click += BtnOk_Click;
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            Intent novaTela = new Intent(this, typeof(tela2));
            novaTela.PutExtra("nome", txtNome.Text);
            novaTela.PutExtra("categoria", txtCategoria.Text);
            StartActivity(novaTela);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
