using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStoreApp
{
    class Store
    {
        Phone [] phoneMainArr = new Phone[0];

        public void AddPhone (Phone newPhone)
        {
            Array.Resize(ref phoneMainArr, phoneMainArr.Length + 1);
            phoneMainArr[phoneMainArr.Length - 1] = newPhone;
        }

        public void GetAllPhones()
        {
            foreach (var phones in phoneMainArr)
            {
                Console.WriteLine($"Id:{phones.Id} Name:{phones.Name} Brand:{phones.Brand} Quantity:{phones.Quantity} Price:{phones.Price} System:{phones.System} Ram:{phones.RAM}");
            }
        }

        public Phone [] GetPhonesBySystem(string system)
        {
            Phone[] phonesystem = new Phone[0];

            foreach (var phone in phoneMainArr)
            {
                if (phone.System.ToUpper() == system.ToUpper())
                {
                    Array.Resize(ref phonesystem, phonesystem.Length + 1);
                    phonesystem[phonesystem.Length - 1] = phone;
                }

            }
            return phonesystem;
        }


        public Phone[] GetPhonesByPrice(double minPrice,double maxPrice)
        {
            Phone[] phoneByPrice = new Phone[0];
            foreach (var item in phoneMainArr)
            {
                if (item.Price>minPrice && item.Price < maxPrice)
                {
                    Array.Resize(ref phoneByPrice, phoneByPrice.Length + 1);
                    phoneByPrice[phoneByPrice.Length - 1] = item;
                }
            }

            return phoneByPrice;

        }
    }
}
