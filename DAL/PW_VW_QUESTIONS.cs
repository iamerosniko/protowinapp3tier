//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PW_VW_QUESTIONS
    {
        public System.Guid QuestionID { get; set; }
        public string QuestionDesc { get; set; }
        public bool IsCommon { get; set; }
        public bool IsMultipleAns { get; set; }
        public bool IsActive { get; set; }
    }
}
