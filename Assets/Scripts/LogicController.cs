using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    /// <summary>
    /// Предоставляет доступ к логическим операциям.
    /// </summary>
    class LogicController
    {
        /// <summary>
        /// Конъюнкция.
        /// </summary>
        /// <param name="a">Первый параметр.</param>
        /// <param name="b">Второй параметр.</param>
        /// <returns>Результат.</returns>
        public static bool Conjunction(bool a, bool b)
        {
            return a & b;
        }

        /// <summary>
        /// Дизъюнкция.
        /// </summary>
        /// <param name="a">Первый параметр.</param>
        /// <param name="b">Второй параметр.</param>
        /// <returns>Результат.</returns>
        public static bool Disjunction(bool a, bool b)
        {
            return a | b;
        }

        /// <summary>
        /// Инверсия.
        /// </summary>
        /// <param name="a">Параметр, который нужно инверсировать.</param>
        /// <returns>Результат.</returns>
        public static bool Inversion(bool a)
        {
            return !a;
        }

        /// <summary>
        /// Импликация.
        /// </summary>
        /// <param name="a">Первый параметр.</param>
        /// <param name="b">Второй параметр.</param>
        /// <returns>Результат.</returns>
        public static bool Implication(bool a, bool b)
        {
            return !a | b;
        }

        /// <summary>
        /// Эквиваленция.
        /// </summary>
        /// <param name="a">Первый параметр.</param>
        /// <param name="b">Второй параметр.</param>
        /// <returns>Результат.</returns>
        public static bool Equalisation(bool a, bool b)
        {
            return a.Equals(b);
        }
    }
}
