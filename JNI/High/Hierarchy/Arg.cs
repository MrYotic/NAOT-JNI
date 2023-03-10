using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSJNI.High.Hierarchy;
public class Arg
{
    public Arg(string sig)
    {
        Sig = sig;
    }

    public Arg(JType type) : this(SigGen.Arg(type)) { }

    public string Sig { get; protected set; }
}

public class ArrayArg : Arg
{
    public ArrayArg(string sig, int dim) : base(sig)
    {
        Sig = new string('[', dim) + Sig;
    }

    public ArrayArg(JType type, int dim) : base(type)
    {
        Sig = new string('[', dim) + Sig;
    }
}