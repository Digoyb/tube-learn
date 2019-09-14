using System;
using TubeLearn.Domain.Entities.Base;

namespace TubeLearn.Domain.entities
{
    public class Canal: EntityBase
    {

        public string Nome { get; set; }
        public string UrlLogo { get; set; }
        public Usuario Usuario { get; set; }
    }
}