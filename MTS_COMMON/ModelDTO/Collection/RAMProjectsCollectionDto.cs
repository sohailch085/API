namespace MTS_COMMON.ModelDTO.Collection
{
    public class RAMProjectsCollectionDto
    {
        public long TRID { get; set; } = 0;
        public string? EIACODXA { get; set; } = string.Empty;
        public string? LCNTYPXB { get; set; } = string.Empty;
        public long? TYPEOFPRODUCTID { get; set; }
        public long? LIFECYCLEPHASEID { get; set; }
        public string PROJECTNAME { get; set; } = string.Empty;
        public float? OPERATIONLIFE { get; set; }
        public string? DESCRIPTION { get; set; } = string.Empty;
        public string? REMARKS { get; set; } = string.Empty;
        public DateTime? PROGRAMSTARTDATE { get; set; } = DateTime.Now;
        public DateTime? PROGRAMENDDATE { get; set; } = DateTime.Now;
        public DateTime? CREATEDDATE { get; set; } = DateTime.Now;
        public DateTime? UPDATEDATE { get; set; } = DateTime.Now;
        public string USERIDZU { get; set; } = string.Empty;
    }
}
