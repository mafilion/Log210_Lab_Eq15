//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LivresAuteurs
    {
        public int IDLivresAuteurs { get; set; }
        public int IDAuteur { get; set; }
        public int IDLivre { get; set; }
    
        public virtual Livre Livre { get; set; }
        public virtual Auteur Auteur { get; set; }
    }
}
