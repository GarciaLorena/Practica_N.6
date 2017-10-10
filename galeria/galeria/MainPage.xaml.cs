using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace galeria
{
    public partial class MainPage : CarouselPage
    {
        Int32 contador = 0;
        Int32 contador1 = 0;
        Int32 img1 = 0;
        Int32 img2 = 0;
        Int32 img3 = 0;
        Int32 img4 = 0;
        Int32 img5 = 0;
        Int32 img6 = 0;
        Int32 img7 = 0;
        Int32 img8 = 0;
        Int32 img9 = 0;
        Int32 img10 = 0;
        Int32 img11 = 0;
        Int32 img12 = 0;
        Int32 img13 = 0;
        Int32 img14 = 0;
        Int32 img15 = 0;
        Int32 img16 = 0;
        Int32 img17 = 0;
        Int32 img18 = 0;
        Int32 img19 = 0;
        Int32 img20 = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Mg1(object sender, EventArgs e)
        {
            img1 = 1;
            if (img1 == 1)
            {
                contador = 1;
            }
        }

        private void Ng1(object sender, EventArgs e)
        {
            img2 = 0;
            if (img2 == 0)
            {
                contador1 = 1;
            }
        }

        private void Mg2(object sender, EventArgs e)
        {
            img3 = 1;
            if (img3 == 1)
            {
                contador = contador+1;
            }
        }
        private void Ng2(object sender, EventArgs e)
        {
            img4 = 0;
            if (img4 == 0)
            {
                contador1 = contador1+1;
            }
        }
        

        private void Mg3(object sender, EventArgs e)
        {
            img5 = 1;
            if (img5 == 1)
            {
                contador = contador + 1;
            }
        }

        private void Ng3(object sender, EventArgs e)
        {
            img6 = 0;
            if (img6 == 0)
            {
                contador1 = contador1 + 1;
            }
        }

        private void Mg4(object sender, EventArgs e)
        {
            img7 = 1;
            if (img7 == 1)
            {
                contador = contador + 1;
            }
        }

        private void Ng4(object sender, EventArgs e)
        {
            img8 = 0;
            if (img8 == 0)
            {
                contador1 = contador1 + 1;
            }
        }

        private void Mg5(object sender, EventArgs e)
        {
            img9 = 1;
            if (img9 == 1)
            {
                contador = contador + 1;
            }
        }

        private void Ng5(object sender, EventArgs e)
        {
            img10 = 0;
            if (img10 == 0)
            {
                contador1 = contador1 + 1;
            }
        }

        private void Mg6(object sender, EventArgs e)
        {
            img11 = 1;
            if (img11 == 1)
            {
                contador = contador + 1;
            }
        }

        private void Ng6(object sender, EventArgs e)
        {
            img12 = 0;
            if (img12 == 0)
            {
                contador1 = contador1 + 1;
            }
        }

        private void Mg7(object sender, EventArgs e)
        {
            img13 = 1;
            if (img13 == 1)
            {
                contador = contador + 1;
            }
        }

        private void Ng7(object sender, EventArgs e)
        {
            img14 = 0;
            if (img14 == 0)
            {
                contador1 = contador1 + 1;
            }
        }

        private void Mg8(object sender, EventArgs e)
        {
            img15 = 1;
            if (img15 == 1)
            {
                contador = contador + 1;
            }
        }

        private void Ng8(object sender, EventArgs e)
        {
            img16 = 0;
            if (img16 == 0)
            {
                contador1 = contador1 + 1;
            }
        }

        private void Mg9(object sender, EventArgs e)
        {
            img17 = 1;
            if (img17 == 1)
            {
                contador = contador + 1;
            }
        }

        private void Ng9(object sender, EventArgs e)
        {
            img18 = 0;
            if (img18 == 0)
            {
                contador1 = contador1 + 1;
            }
        }

        private void Mg10(object sender, EventArgs e)
        {
            img19 = 1;
            if (img19 == 1)
            {
                contador = contador + 1;
            }
           
        }

        private void Ng10(object sender, EventArgs e)
        {
            img19 = 0;
            if (img19 == 0)
            {
                contador1 = contador1 + 1;
            }
           
        }

        private void M(object sender, EventArgs e)
        {
            DisplayAlert("IMAGENES QUE ME GUSTAN:", resultado.Text + contador, "OK");
        }

        private void NM(object sender, EventArgs e)
        {
            DisplayAlert("IMAGENES QUE NO ME GUSTAN:", resultado.Text + contador1, "OK");
        }
    }
}
