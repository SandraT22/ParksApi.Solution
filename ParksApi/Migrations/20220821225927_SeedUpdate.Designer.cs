﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

namespace ParksApi.Migrations
{
    [DbContext(typeof(ParksApiContext))]
    [Migration("20220821225927_SeedUpdate")]
    partial class SeedUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("DogsAllowed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Location")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ParkMgmt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Description = "Tucked away in the Rogue Valley has some natue and woods to explore. Features swimming, fishing, boating activies",
                            DogsAllowed = true,
                            Location = "SW Oregon",
                            Name = "Valley of the Rogue River",
                            ParkMgmt = "State Park"
                        },
                        new
                        {
                            ParkId = 2,
                            Description = "Has lush rainforest and senic coastal vistas. Features hiking, historical sites,  kayaking, fishing, and wildlife",
                            DogsAllowed = true,
                            Location = "NW Oregon",
                            Name = "Lewis and Clark National Historical Park",
                            ParkMgmt = "National Park"
                        },
                        new
                        {
                            ParkId = 3,
                            Description = "Rugged rocky terrain, colorful craggy badlands, features a museum, educational film on geology and fossils, hiking ",
                            DogsAllowed = true,
                            Location = "East-Central Oregon ",
                            Name = "John Day Fossil Beds National Monument",
                            ParkMgmt = "National Park"
                        },
                        new
                        {
                            ParkId = 4,
                            Description = "Offers tours of cave complexes, Explore underground caverns. Features hunting, hiking, wildlife",
                            DogsAllowed = true,
                            Location = "SW Oregon",
                            Name = "Oregon Caves National Monument and Preserve",
                            ParkMgmt = "National Park"
                        },
                        new
                        {
                            ParkId = 5,
                            Description = "Beautiful Scenery, boasting of the deepest river gorge in North America, features fishing, swimming, camping, and kayaking",
                            DogsAllowed = true,
                            Location = "NE Oregon",
                            Name = "Hells Canyon National Recreation Area",
                            ParkMgmt = "National Park"
                        },
                        new
                        {
                            ParkId = 6,
                            Description = "Home to spectacular lakes and lava flows.Formed after a violent volcanic eruption, Newberry Caldera is now home to the two arresting alpine lakes of Paulina Lake and East Lake. Features hiking and horse back riding.",
                            DogsAllowed = true,
                            Location = "Central Oregon",
                            Name = "Newberry National Volcanic Monument ",
                            ParkMgmt = "National Park"
                        },
                        new
                        {
                            ParkId = 7,
                            Description = "Most known for its craggy cliffs and climbing routes, Volcanic in origin, it showcases steep cliffs and sheer spires, with captivating climbing routes wherever you look. Features hiking, climbing, and camping.",
                            DogsAllowed = true,
                            Location = "Central Oregon",
                            Name = "Smith Rock State Park",
                            ParkMgmt = "State Park"
                        },
                        new
                        {
                            ParkId = 8,
                            Description = "Home to beautiful beaches, forests, lakes, and islands. Reaching up to 150 meters in height, the dunes that dominate the park make up the largest expanse of coastal sands in the whole of North America. . These sprawling, windswept sandscapes make for a breathtaking sight and were actually the inspiration for Frank Herberts famed sci-fi novel Dune. Features horseback riding, dune-buggying, camping, fishing, and canoeing.",
                            DogsAllowed = true,
                            Location = " ",
                            Name = "Oregon Dunes National Recreation Area",
                            ParkMgmt = "W Oregon"
                        },
                        new
                        {
                            ParkId = 9,
                            Description = "Blessed with an abundance of water falls Silver Falls is considered the crowned jewel of Oregons state park system. Features horesback riding, camping, and hiking. While dogs are mostly allowed, they are not allowed on the Cayon Trail.",
                            DogsAllowed = false,
                            Location = "NW Oregon",
                            Name = "Silver Falls State Park",
                            ParkMgmt = "State Park"
                        },
                        new
                        {
                            ParkId = 10,
                            Description = "Dotted about its stunning shores, which stretch almost 15 kilometers in total, are sensational sea stacks, tidal pools, and beaches, with lush rainforest found inland. In the state park, visitors can go wildlife watching or stroll along the Oregon Coast Trail and bask in the phenomenal views out over the Pacific Ocean. Features hinking, and historic sites.",
                            DogsAllowed = true,
                            Location = "NW Oregon",
                            Name = "Ecola State Park",
                            ParkMgmt = "State Park"
                        },
                        new
                        {
                            ParkId = 11,
                            Description = "The national scenic areas delightful and diverse landscapes lend themselves perfectly to all kinds of outdoor activities, with everything from hiking and mountain biking to rock climbing and rafting on offer.",
                            DogsAllowed = true,
                            Location = "NW Oregon",
                            Name = "Columbia River Gorge National Senic Area",
                            ParkMgmt = "National Park"
                        },
                        new
                        {
                            ParkId = 12,
                            Description = "Hemmed in on all sides by the crumbling cliffs of a long collapsed caldera, the brilliantly blue waters of Crater Lake make for a spectacular sight. The deepest lake in the US offers up fabulous photo opportunities to visitors from its rugged rim. Features fishing, scuba diving, and boat tours.",
                            DogsAllowed = true,
                            Location = "S Oregon",
                            Name = "Crater Lake National Park",
                            ParkMgmt = "National Park"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
