using System;
using System.Collections.Generic;
using System.Linq;

namespace C_projectviva.Sections
{
    // Member 04 — Sections module: add / update / delete / search estate sections.
    //
    // Rules from CONTRACTS.md:
    //   * Validate before saving: name is required, area must be a number >= 0.
    //   * Wrap real DB calls in try/catch and show the error to the user.
    //   * All DB access should eventually go through the shared DatabaseHelper (Member 01).
    //
    // This starter keeps sections in memory so you can build and test the logic today.
    // Swap the in-memory list for DatabaseHelper + SqlParameter calls once Core is ready.
    public class SectionManager
    {
        private readonly List<EstateSection> _sections = new List<EstateSection>();
        private int _nextId = 1;

        public IReadOnlyList<EstateSection> GetAll()
        {
            return _sections;
        }

        public EstateSection Add(string name, decimal area)
        {
            Validate(name, area);
            var section = new EstateSection(_nextId++, name.Trim(), area);
            _sections.Add(section);
            return section;
        }

        public void Update(int id, string name, decimal area)
        {
            Validate(name, area);
            var section = Find(id);
            section.Name = name.Trim();
            section.AreaHectares = area;
        }

        public void Delete(int id)
        {
            _sections.Remove(Find(id));
        }

        public List<EstateSection> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _sections.ToList();

            keyword = keyword.Trim().ToLowerInvariant();
            return _sections
                .Where(s => s.Name.ToLowerInvariant().Contains(keyword))
                .ToList();
        }

        private EstateSection Find(int id)
        {
            var section = _sections.FirstOrDefault(s => s.Id == id);
            if (section == null)
                throw new InvalidOperationException("Section with Id " + id + " was not found.");
            return section;
        }

        private static void Validate(string name, decimal area)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Section name is required.");
            if (area < 0)
                throw new ArgumentException("Area must be a number greater than or equal to 0.");
        }
    }
}
