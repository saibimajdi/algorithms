// See https://aka.ms/new-console-template for more information

var airports = new[] { "TUN", "DJERBA", "SFAX", "MONASTIR", "TBARKA", "GAFSA" };
var routes = new[] {
            new[] { "TUN", "DJERBA" },
            new[] { "DJERBA", "SFAX" },
            new[] { "MONASTIR", "SFAX" },
            new[] { "SFAX", "TBARKA" },
            new[] { "TBARKA", "GAFSA" },
            new[] { "GAFSA", "MONASTIR" }
        };


algorithms.BFS.run(airports, routes, "TUN", "GAFSA");