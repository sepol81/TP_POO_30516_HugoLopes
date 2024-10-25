using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.models
{
    public class FireFighter : Person
    {

    public FireFighter(int id, string name, string citCard, DateTime birthday, int age, string email, string phone, string address, string rank, bool isAvailable)
            : base(id, name, citCard, birthday, age, email, phone, address) { }

    public override string TypePerson()
        {
            return $"ID:{Id}" +
                     $"Name{Name}" +
                     $"CitCard{CitCard}" +
                     $"Birthday{Birthday}" +
                     $"Age{Age}" +
                     $"Email{Email}" +
                     $"Phone{Phone}" +
                     $"Address{Address}";
        }

        public static implicit operator FireFighter(FireFighter v)
        {
            throw new NotImplementedException();
        }
    }
}
