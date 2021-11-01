using System;

namespace PhoneStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product prd = new Product(1,"iphone","Apple",20,2000);
            //Console.WriteLine(prd);


            Phone phn = new Phone("IOS", 16 , 1, "iphone", "Apple", 20, 2000);
            Phone phn1 = new Phone("Android", 16 , 1, "A50", "Samsung", 20, 2000);
            Phone phn2 = new Phone("MIUI", 16 , 1, "Note 7", "Xiaomi", 20, 420);
            //Console.WriteLine(phn);

            Store store = new Store();

            store.AddPhone(phn);
            store.AddPhone(phn1);
            store.AddPhone(phn2);

            //store.GetAllPhones();

            

           //Phone[] filteredPhones = store.GetPhonesBySystem("iOs");
           // foreach (var item in filteredPhones)
           // {
           //     Console.WriteLine(item);
           // }

            Phone[] phones = store.GetPhonesByPrice(1000,4000);

            foreach (var item in phones)
            {
                Console.WriteLine(item);
            }
        }
    }
}
