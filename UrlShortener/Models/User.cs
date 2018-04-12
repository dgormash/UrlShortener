using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UrlShortener.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage="Поле обязательно для заполнения")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string UserPassword { get; set; }
        public string AuthorizationToken { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}