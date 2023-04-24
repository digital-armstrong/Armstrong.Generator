using System;
using Armstrong.Generator.Models;

namespace Armstrong.Generator.Helpers
{
  internal class EnvironmentHelper
  {
    public static string GetEnvirovmentVariable(string name)
    {
      var variable = Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Process);

      if (string.IsNullOrWhiteSpace(variable))
        throw new EnvirovmentVariableException($"Переменная среды \"{name}\" не задана, пустая или находится не в среде \"Process\"");

      return variable;
    }
  }
}
