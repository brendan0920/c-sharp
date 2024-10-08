﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SalesDatabaseEFConsole.Models;

[Table("Region")]
[Index("Name", Name = "UQ_Region_Name", IsUnique = true)]
public partial class Region
{
    [Key]
    public int Id { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [InverseProperty("Region")]
    public virtual ICollection<SalesPerson> SalesPeople { get; set; } = new List<SalesPerson>();

    // constructor
    public Region(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return $"Region - Id:{Id}, Name: {Name}";
    }
}
