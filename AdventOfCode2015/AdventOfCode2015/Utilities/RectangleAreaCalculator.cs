using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2015.Utilities
{
    internal class RectangleAreaCalculator
    {
        private List<List<int>> _dimensions;
        private List<int> _areas;
        private int _totalArea;
        private int _totalLength;

        // Expects a list of sorted dimensions in ascending order
        public RectangleAreaCalculator(List<List<int>> dimensions)
        {
            _dimensions = dimensions;
            _areas = new List<int>();
            _totalArea = 0;
            _totalLength = 0;
        }

        public void CalculateAreas()
        {
            foreach (var dimension in _dimensions)
            {
                int totalArea = 0;
                for (int i = 0; i < dimension.Count; i++)
                {
                    var area = dimension[i] * dimension[(i + 1) % dimension.Count];
                    totalArea += 2 * area;
                    if (i == 0)
                    {
                        totalArea += area;
                    }
                }
                _totalArea += totalArea;
            }
        }

        public void CalculateRibbonLength()
        {
            foreach (var dimension in _dimensions)
            {
                int totalLen = 0;
                int volume = 1;
                for (int i = 0; i < dimension.Count; i++)
                {
                    volume *= dimension[i];
                    if (i < dimension.Count - 1)
                    {
                        totalLen += dimension[i] * 2;
                    }
                }
                _totalLength += totalLen + volume;
            }
        }

        public int GetTotalArea()
        {
            return _totalArea;
        }

        public int GetTotalLength()
        {
            return _totalLength;
        }
    }
}
