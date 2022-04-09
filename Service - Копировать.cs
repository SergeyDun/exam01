namespace exam01
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class Service
    {
        public string TextDiscount
        {
            get
            {
                if (Discount == 0)
                {
                    return null;
                }
                else
                {
                    return "Скидка " + (Discount * 100).ToString() + "%";
                }
            }
        }

        public string TextCost
        {
            get
            {
                if (TextDiscount == null)
                {
                    return Math.Round(Cost, 2).ToString() + "рублей";
                }
                else
                {
                    var f = (float)Cost * (1 - Discount);
                    return Math.Round(Cost, 2).ToString() + "рублей" + "Новая стоимость" + Math.Round((decimal)f, 2).ToString() + "рублей";
                }
            }
        }
       public double DurationlnMin
        {
            get
            {
                return Math.Round((double)DurationInSeconds / 60);
            }
        }
        public string ColorService
        {
            get
            {
                if(TextDiscount ==null)
                {
                    return "White";

                }
                else
                {
                    return "#FFE5FABF";
                }
            }
        }
    }
}
