namespace TeaEstate
{
    // Member 04 — model for one estate section (a named block of the tea estate).
    // OOP: Encapsulation — data is exposed through public properties.
    // Maps to the EstateSection table (SectionID PK IDENTITY, SectionName, Area DECIMAL).
    public class EstateSection
    {
        public int SectionID { get; set; }       // primary key (auto-number in the DB)
        public string SectionName { get; set; }   // e.g. "North Field"
        public decimal Area { get; set; }          // size of the section (in hectares)
    }
}
