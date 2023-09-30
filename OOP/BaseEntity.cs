using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BaseEntity
    {
        /// <summary>
        /// Enttiy Id
        /// </summary>
        public Guid EntityId  { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public bool? IsCanceled { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUserId { get; set; }


        //public T GetById(Guid Id)
        //{
        //    T base
        //    return T;
        //}
    }
}
