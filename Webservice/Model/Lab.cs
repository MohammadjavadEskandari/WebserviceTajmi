using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webservice.Model
{
    public class Lab
    {
        public int LabID { get; set; }
        public string LabName { get; set; }
        public string LabShort { get; set; }
        public double? LabCode { get; set; }
        public string Part { get; set; }
        public string Unit { get; set; }
        public string Disket5 { get; set; }
        public string Disket7 { get; set; }
        public int? KitID { get; set; }
        public int? NumberDo { get; set; }
        public bool? SargroohYes { get; set; }
        public bool? ErjaYes { get; set; }
        public bool? JabehYes { get; set; }
        public bool? MicroscopicYes { get; set; }
        public bool? PercentYes { get; set; }
        public double? MinAll { get; set; }
        public double? MaxALL { get; set; }
        public double? MinMen { get; set; }
        public double? MaxMen { get; set; }
        public double? MinWomen { get; set; }
        public double? MaxWomen { get; set; }
        public double? MinChild { get; set; }
        public double? MaxChild { get; set; }
        public double? MinNeo { get; set; }
        public double? MaxNeo { get; set; }
        public string Comment { get; set; }
        public bool? FaniOmoomiFani { get; set; }
        public bool? FaniPath { get; set; }
        public bool? NumPath { get; set; }
        public int? Partm { get; set; }
        public float? Tarafeh1D { get; set; }
        public float? Tarafeh2D { get; set; }
        public float? Tarafeh3D { get; set; }
        public float? Tarafeh4D { get; set; }
        public float? Tarafeh1K { get; set; }
        public float? Tarafeh2K { get; set; }
        public float? Tarafeh3K { get; set; }
        public float? Tarafeh4K { get; set; }
        public float? Tafavot1 { get; set; }
        public float? Tafavot2 { get; set; }
        public float? Tafavot3 { get; set; }
        public int? Hazineh { get; set; }
        public int? PartID { get; set; }
        public bool? JavabSub { get; set; }
        public bool? Kit { get; set; }
        public int? KitDefaukt { get; set; }
        public int? DayResult { get; set; }
        public string CommentMen { get; set; }
        public string CommentAll { get; set; }
        public string CommentWomen { get; set; }
        public string CommentChild { get; set; }
        public string CommentNeo { get; set; }
        public string DefaultResult { get; set; }
        public bool? BoxLab { get; set; }
        public byte? ChoosePrintName { get; set; }
        public int? Priority { get; set; }
        public int? GroupLabal { get; set; }
        public float? Tafavot4 { get; set; }
        public byte[] ImageRpt { get; set; }
        public bool? MMama { get; set; }
        public int CountLab { get; set; }
        public string AnswerType { get; set; }
    }
}
