using System;
using Validateur.Class.Nombre;

namespace Validateur.Type
{
    /// <summary>
    /// Validateur pour un string.
    /// </summary>
    public static class String
    {
        /// <summary>
        /// Vérifie que le string est bien renseigné.
        /// </summary>
        /// <param name="nomParametre">Nom du string.</param>
        public static void Obligatoire(this string s, string nomParametre)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException($"Le paramètre {nomParametre} est obligatoire.");
            }
        }

        /// <summary>
        /// Lève une exceptions si le nombre de caractères est supérieurs.
        /// </summary>
        /// <param name="valeurMaximum">Nombre de caractère maximum.</param>
        /// <param name="nomParametre">Nom du paramètre.</param>
        public static void CaractereMaximum(this string s, int valeurMaximum, string nomParametre)
        {
            s.NonNull(nomParametre);

            if (s.Length > valeurMaximum)
            {
                throw new ArgumentException($"Le paramètre {nomParametre} est supérieur à {valeurMaximum} caractères.");
            }
        }

        /// <summary>
        /// Lève une exceptions si le nombre de caractères est inférieur.
        /// </summary>
        /// <param name="valeurMinimum">Nombre de caractère minimum.</param>
        /// <param name="nomParametre">Nom du paramètre.</param>
        public static void CaractereMinimum(this string s, int valeurMinimum, string nomParametre)
        {
            s.NonNull(nomParametre);

            if (s.Length  < valeurMinimum)
            {
                throw new ArgumentException($"Le paramètre {nomParametre} est supérieur à {valeurMinimum} caractères.");
            }
        }
    }
}
