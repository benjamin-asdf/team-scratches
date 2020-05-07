using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;


public static class Programm {

    public static void Main(string[] args) {
        Console.WriteLine("==== InterfaceAsParam ====\n");

        var bestInstance = new BestClass();
        var hashCode = bestInstance.GetHashCode();

        Console.WriteLine(hashCode);
        localFunc(bestInstance);
        Debug.Assert(!bestInstance.isEnabled);

        void localFunc(IMyInterface e) {
            Console.WriteLine(e.GetHashCode());
            e.Destroy();
        }

    }

    public class BestClass : IMyInterface {
        public bool isEnabled;

        public BestClass() {
            isEnabled = true;
        }

        public void Destroy() {
            isEnabled = false;
        }

    }

    public interface IMyInterface {
        public void Destroy();
    }

}
