//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WF_GestionStock
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mouvement
    {
        public int Id { get; set; }
        public string TypeMouvement { get; set; }
    
        public virtual Produit Produit { get; set; }
    }
}
