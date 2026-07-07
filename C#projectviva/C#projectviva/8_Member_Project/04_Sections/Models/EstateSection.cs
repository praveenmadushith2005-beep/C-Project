using System;

namespace C_projectviva.Sections
{
    // Member 04 — Sections module.
    // One estate section = a named area of the tea estate.
    // DB table (per TEAM_TASKS.md): EstateSection
    public class EstateSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AreaHectares { get; set; }

        public EstateSection() { }

        public EstateSection(int id, string name, decimal areaHectares)
        {
            Id = id;
            Name = name;
            AreaHectares = areaHectares;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} ({2} ha)", Id, Name, AreaHectares);
        }
    }
}
