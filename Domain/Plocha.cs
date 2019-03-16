using System.Linq;

namespace Domain
{
    public class Plocha
    {
        public Devitka[] Rows { get; private set; }

        public Devitka[] Columns { get; private set; }

        public Plocha()
        {
            Initialize();
        }

        private void Initialize()
        {
            var allFields = new Policko[81];

            Rows = new Devitka[9];
            for (int i = 0; i < 9; i++)
            {
                Rows[i] = new Devitka(allFields.Where((pol, ind) => ind >= 9 * i && ind < 9 * (i + 1)));
            }

            Columns = new Devitka[9];

        }
    }
}