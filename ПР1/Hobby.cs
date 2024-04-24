using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР1
{
    internal class Hobby
    {
        public double sum { get; private set; }
        public string hobby_name { get; private set; }
        public string description { get; private set; }
        public string describe { get; private set; }

        string Hobby_cost()
        { // счетаю сколько трачу на хобби
            if (sum < 4800) return "Ваше хобби идеально подходит для бедного студента!";
            else if (sum >= 15000) return "Вы явно очень богатый человек для студента!";
            else return "Вы или очень богатый студент, или вы уже в долгах! Подумайте может стоит найти что-то менее дорогое.";
        }
        public Hobby(double sum, string hobby_name, string description)
        {
            this.description = description;
            this.sum = sum;
            this.hobby_name = hobby_name;
            describe = Hobby_cost();
        }
    }
}
