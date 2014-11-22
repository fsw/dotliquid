using System;

namespace DotLiquid
{
   /// <summary>
   /// Specifies that property is safe to be rendered by DotLiquid.
   /// Declaring class needs [LiquidType] attribute
   /// </summary>
   [AttributeUsage(AttributeTargets.Property)]
   public class LiquidPropertyAttribute : Attribute
   {

   }
}
