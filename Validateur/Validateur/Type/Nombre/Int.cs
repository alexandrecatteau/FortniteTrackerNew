using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validateur.Type.Nombre
{
    /// <summary>
    /// Validateur pour les int.
    /// </summary>
    public static class Int
    {
        /// <summary>
        /// Lance une exception si la valeur n'est pas comprise entre 2 autres.
        /// </summary>
        /// <param name="valeurMaximum">Valeur maximum.</param>
        /// <param name="valeurMinimum">Valeur minimum</param>
        /// <param name="nomParametre">Nom du paramètre.</param>
        public static void Entre(this int i, int valeurMaximum, int valeurMinimum, string nomParametre)
        {
            i.NonNull(nomParametre);

            if(i>valeurMaximum || i < valeurMinimum)
            {
                throw new ArgumentException($"Le paramètre {nomParametre} n'est pas compris entre {valeurMinimum} et {valeurMaximum}");
            }
        }

        /// <summary>
        /// Lance une exception si la valeur est supérieur.
        /// </summary>
        /// <param name="valeurMaximum">Valeur maximum.</param>
        /// <param name="nomParametre">Nom du parametre.</param>
        public static void Inferieur(this int i, int valeurMaximum, string nomParametre)
        {
            i.NonNull(nomParametre);

            if (i > valeurMaximum)
            {
                throw new ArgumentException($"Le paramètre {nomParametre} doit être suérieur à {valeurMaximum}.");
            }
        }

        /// <summary>
        /// Lance une exception si la valeur est inférieur à 0.
        /// </summary>
        /// <param name="nomParametre">Nom du paramètre.</param>
        public static void Positif(this int i, string nomParametre)
        {
            i.NonNull(nomParametre);

            if (i < 0)
            {
                throw new ArgumentException($"Le paramètre {nomParametre} doit être supérieur à 0.");
            }
        }

        /// <summary>
        /// Lance une exception si la valeur est inférieur à 1.
        /// </summary>
        /// <param name="nomParametre">Nom du paramètre.</param>
        public static void StrictementPositif(this int i, string nomParametre)
        {
            i.NonNull(nomParametre);

            if (i < 1)
            {
                throw new ArgumentException($"Le paramètre {nomParametre} doit être supérieur à 1.");
            }
        }

        /// <summary>
        /// Lance une exception si la valeur est inférieur à la valeur minimum.
        /// </summary>
        /// <param name="valeurMinimum">Valeur minimum.</param>
        /// <param name="nomParametre">Nom du paramètre.</param>
        public static void Superieur(this int i, int valeurMinimum, string nomParametre)
        {
            i.NonNull(nomParametre);

            if (i < valeurMinimum)
            {
                throw new ArgumentException($"Le paramètre {nomParametre} doit être inférieur à {valeurMinimum}.");
            }
        }
    }
}
