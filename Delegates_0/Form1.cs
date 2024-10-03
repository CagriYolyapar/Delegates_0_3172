using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_0
{
    public partial class Form1 : Form
    {


        //Delegate'lerin de tıpkı metotlar gibi imzaları vardır. Ve bir delegate icerisinde sadece kendi imzasına uygun metotları tutabilir..Delegate'ler referans tiplerdir...



        //Action, Func, Predicate



        //Action delegate  : Ya hic parametre almayan ya da 16'ya kadar parametre alabilen ve geriye deger döndürmeyen bir delegate'tir... Action tipi generic olarak cagrılmıyorsa anlayın ki hic parametre almayacaktır...

        Action action;

        Action<int, string> action2;


        //Predicate delegate : İcerisine bir parametre alan ve geriye bool deger döndüren bir delegate'tir...

        Predicate<string> predicate;


        //Func delegate  : 


        Func<int,string> func;

    







        delegate void MyDelegate(string isim);



        delegate void MySecondDelegate(); 

        delegate void MyThirdDelegate(string isim, int yas);

        delegate int MyForthDelegate();


        //public void Selamla(string item)
        //{
        //    MessageBox.Show($"Hosgeldin {item}");
           
        //}


        //public void Yazdir(string item)
        //{
        //    Text = item;
        //     MessageBox.Show(item);
        //}
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MyDelegate myDelegate = new MyDelegate(Selamla);
            //myDelegate += Yazdir;

            //myDelegate.Invoke("Cagri");


            //MyDelegate myDelegate = new MyDelegate(x => 
            //{
            //    Text = x;
            //    MessageBox.Show(x);

            //});


            //myDelegate.Invoke("Deneme");


            //MySecondDelegate mySecondDelegate = new MySecondDelegate( () => MessageBox.Show("Hello"));

            //MyThirdDelegate mySecondDelegate = new MyThirdDelegate((x,y) => MessageBox.Show("Hello"));


            //Arrow functionlarda süslü parantez yoksa direkt dönen degeri yazabilirsiniz...Ancak süslü parantez varsa acıkca return yazarak degeri döndürmeniz gerekir...


            //MyForthDelegate myForthDelegate = new MyForthDelegate(() =>12);


            //MyForthDelegate myForthDelegate2 = new MyForthDelegate(() => 
            //{

            //    MessageBox.Show("Hello");
            //    return 12;

            //} );

            action = new Action(() => MessageBox.Show("asdadas"));

            action2 = new Action<int, string>((x,y)=>
            {
                Text = x.ToString();
                Text = y.ToString();    
            });


            predicate = new Predicate<string>(x => x.Contains("a"));


            List<string> sehirler = new List<string>() {"İstanbul","Eskişehir" };


            string eleman =  sehirler.Find(predicate);


            func = new Func<int, string>(x => "asadasd");

           

        }
    }
}
