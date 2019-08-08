using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DesignPattern.CreationalPatterns.Builder
{
    public interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();
    }

    public class ConcreteBuilder : IBuilder
    {
        private Material _material = new Material();

        public void BuildPart1()
        {
            _material.Part1 = "Part 1";
        }

        public void BuildPart2()
        {
            _material.Part2 = "Part 2";
        }

        public void BuildPart3()
        {
            _material.Part3 = "Part 3";
        }
    }

    public class Material
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }
    }

    public class MaterialMainProgram
    {
        public void Constructor(IBuilder IBuilder)
        {
            IBuilder.BuildPart1();
            IBuilder.BuildPart2();
            IBuilder.BuildPart3();
        }
    }
}
