using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMDemo.ViewModels
{
    public class ViewModelOperaciones :ViewModelBase
    {

        #region  Atributos
        string message;
        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    OnPropertyChanged();
                }
            }
        }


        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoAll;
        public int Resultado
        {
            get { return resultadoAll; }
            set
            {
                if (resultadoAll != value)
                {
                    resultadoAll = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Dividir { protected set; get; }
        public ICommand Multiplicar { protected set; get; }


        public ViewModelOperaciones()
        {
            Sumar = new Command(() =>
            {
                Message = "El resultado de la suma es:";
                Resultado = ValorA + ValorB;
            });

            Restar = new Command(() =>
            {
                Message = "El resultado de la resta es:";
                Resultado = ValorA - ValorB;
            });

            Multiplicar = new Command(() =>
            {
                Message = "El resultado de la multiplicación es:";
                Resultado = ValorA * ValorB;

            });

            Dividir = new Command(() =>
            {
                if (ValorB == 0)
                {
                    Resultado = 0;
                    Message = "No puedes dividir entre 0";
                    return;
                }
                else {
                    Message = "El resultado de la división es:";
                    Resultado = ValorA / ValorB;
                }
                

            });

        }

    }
}
