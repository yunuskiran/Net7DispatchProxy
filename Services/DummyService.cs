using System;

namespace AOPDemo.Services
{
    public class DummyService : IDummyService
    {
        public void Add() => Console.WriteLine("Added");

        public void GetLast() => Console.WriteLine("Last");
    }
}