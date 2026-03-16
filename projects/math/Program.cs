// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

var O = (X: 1099, Y: 2000);
var slope = (double)O.Y / O.X;
Console . WriteLine($"A Line form the origin to the point {O} has a slope of {slope}");
