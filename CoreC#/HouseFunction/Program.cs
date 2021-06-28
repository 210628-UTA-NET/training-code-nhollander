using System;

namespace HouseFunction
{
    public class House
    {
        private string _price;
        private string _color;
        public House(){
            Console.WriteLine("This constructor was used");
            _color = "Red";
        }
        //C# way of getting info from fields
        public string Price{
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        //Java way of getting info from fields
        public string getColor(){
            return _color;
        }
        public void setColor(string p_color){
            _color = p_color;
        }
        }
    }

