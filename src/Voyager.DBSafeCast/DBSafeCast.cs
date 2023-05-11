namespace System
{
	public static class DBSafeCast
	{
		public static TType Cast<TType>(this object obj, TType def)
		{
			if (!IsDBNull(obj))
			{
				try
				{
					return (TType)obj;
				}
				catch (InvalidCastException)
				{
					return (TType)findObjectToParse(obj, def);
				}
			}
			else
				return def;

		}

		public static TimeSpan CastTimeSpan(this string value)
		{
			return new TimeSpan(int.Parse(value.Substring(0, 2)), int.Parse(value.Substring(3, 2)), int.Parse(value.Substring(6, 2)));
		}


		public static decimal? CastNullableDecimal(object obj)
		{
			if (!IsDBNull(obj))
				return (decimal)obj;
			else
				return new decimal?();
		}

		public static float? CastNullableFloat(object obj)
		{
			if (!IsDBNull(obj))
				return (float)obj;
			else
				return new float?();
		}


		public static Byte[] CastNullByteArray(object obj)
		{
			if (!IsDBNull(obj))
				return (Byte[])obj;
			else
				return null;
		}

		public static Byte[] CastEmptyByteArray(object obj)
		{
			if (!IsDBNull(obj))
				return (Byte[])obj;
			else
				return new Byte[] { };
		}

		public static Byte? CastNullableByte(object obj)
		{
			if (!IsDBNull(obj))
				return (Byte)obj;
			else
				return new Byte?();
		}


		public static Int32? CastNullableInt32(object obj)
		{
			if (!IsDBNull(obj))
				return (Int32)obj;
			else
				return new Int32?();
		}

		public static Int64? CastNullableInt64(object obj)
		{
			if (!IsDBNull(obj))
				return (Int64)obj;
			else
				return new Int64?();
		}

		public static Int16? CastNullableInt16(object obj)
		{
			if (!IsDBNull(obj))
				return (Int16)obj;
			else
				return new Int16?();
		}


		public static DateTime? CastNullableDateTime(object obj)
		{
			if (!IsDBNull(obj))
				return (DateTime)obj;
			else
				return new DateTime?();
		}


		[Obsolete("Move to CastEmptyString")]
		public static String CastNullableString(object obj)
		{
			if (!IsDBNull(obj))
				return (String)obj;
			else
				return null;
		}

		public static String CastEmptyString(object obj)
		{
			if (!IsDBNull(obj))
				return (String)obj;
			else
				return String.Empty;
		}

		public static String CastString(object obj)
		{
			if (!IsDBNull(obj))
				return (String)obj;
			else
				return string.Empty;
		}

		public static Guid? CastNullableGuid(object obj)
		{
			if (!IsDBNull(obj))
				return (Guid)obj;
			else
				return new Guid?();
		}


		public static Boolean? CastNullableBoolean(object obj)
		{
			if (!IsDBNull(obj))
				return (Boolean)obj;
			else
				return new Boolean?();
		}

		public static object DBNullIF(this string value, string def)
		{
			if ((value != null) && (string.Compare(value, def, true) != 0))
				return value;
			else
				return DBNull.Value;
		}

		public static object DBNullIFEmpty(this string value)
		{
			return DBNullIF(value, string.Empty);
		}

		public static object DBNullIF(this Guid value, Guid def)
		{
			if (value != def)
				return value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Guid value)
		{
			return DBNullIF(value, Guid.Empty);
		}


		public static object DBNullIF(this Nullable<Guid> value, Guid def)
		{
			if ((value != null) && (value.HasValue) && (value.Value != def))
				return value.Value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Nullable<Guid> value)
		{
			return DBNullIF(value, Guid.Empty);
		}

		public static object DBNullIF(Nullable<int> value, int def)
		{
			if ((value != null) && (value.HasValue) && (value.Value != def))
				return value.Value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Nullable<Int64> value, Int64 def)
		{
			if ((value != null) && (value.HasValue) && (value.Value != def))
				return value.Value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Nullable<decimal> value, decimal def)
		{
			if ((value != null) && (value.HasValue) && (value.Value != def))
				return value.Value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Nullable<int> value)
		{
			if ((value != null) && (value.HasValue))
				return value.Value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Nullable<bool> value)
		{
			if ((value != null) && (value.HasValue))
				return value.Value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Nullable<Int64> value)
		{
			if ((value != null) && (value.HasValue))
				return value.Value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Nullable<decimal> value)
		{
			if ((value != null) && (value.HasValue))
				return value.Value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Nullable<Single> value)
		{
			if ((value != null) && (value.HasValue))
				return value.Value;
			else
				return DBNull.Value;
		}


		public static object DBNullIF(this Byte[] value)
		{
			if (value != null)
				return value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Nullable<Double> value)
		{
			if ((value != null) && (value.HasValue))
				return value.Value;
			else
				return DBNull.Value;
		}

		public static object DBNullIF(this Nullable<DateTime> value, DateTime def)
		{
			if ((value.HasValue) && (value.Value != def))
				return value.Value;
			else
				return DBNull.Value;
		}

		static public object DBNullIFMin(this Nullable<DateTime> value)
		{
			return DBNullIF(value, DateTime.MinValue);
		}

		static public object DBNullIF(this int value, int def = 0)
		{
			if (value != def)
				return value;
			else
				return DBNull.Value;
		}


		public static object DBNullIF(this Int64 value, Int64 def = 0)
		{
			if (value != def)
				return value;
			else
				return DBNull.Value;
		}


		public static double? CastNullableDouble(object obj)
		{
			if (!IsDBNull(obj))
				return (double)obj;
			else
				return new double?();
		}

		public static object ToDBNull(this string value)
		{
			if (value != null)
				return value;
			else
				return DBNull.Value;
		}

		private static bool IsDBNull(object obj)
		{
			return (obj == null) || (obj.GetType() == typeof(DBNull));
		}

		private static object findObjectToParse<TType>(object obj, TType def)
		{
			if (obj is string)
				if (def is decimal)
					return decimal.Parse((string)obj, System.Globalization.NumberFormatInfo.InvariantInfo);
				else if (def is int)
					return int.Parse((string)obj);
				else if (def is long)
					return long.Parse((string)obj);
				else if (def is byte)
					return byte.Parse((string)obj);
			return obj;
		}

	}

}