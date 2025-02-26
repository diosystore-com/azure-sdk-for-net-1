﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using NUnit.Framework;

namespace Azure
{
    public class StoringUInt
    {
        public static uint[] UInt32Data => new uint[]
        {
            42,
            uint.MaxValue,
            uint.MinValue
        };

        [Test]
        public void UIntImplicit([ValueSource("UInt32Data")] uint testValue)
        {
            Value value = testValue;
            Assert.AreEqual(testValue, value.As<uint>());
            Assert.AreEqual(typeof(uint), value.Type);

            uint? source = testValue;
            value = source;
            Assert.AreEqual(source, value.As<uint?>());
            Assert.AreEqual(typeof(uint), value.Type);
        }

        [Test]
        public void UIntCreate([ValueSource("UInt32Data")] uint testValue)
        {
            Value value;
            using (MemoryWatch.Create())
            {
                value = Value.Create(testValue);
            }

            Assert.AreEqual(testValue, value.As<uint>());
            Assert.AreEqual(typeof(uint), value.Type);

            uint? source = testValue;

            using (MemoryWatch.Create())
            {
                value = Value.Create(source);
            }

            Assert.AreEqual(source, value.As<uint?>());
            Assert.AreEqual(typeof(uint), value.Type);
        }

        [Test]
        public void UIntInOut([ValueSource("UInt32Data")] uint testValue)
        {
            Value value = new(testValue);
            bool success = value.TryGetValue(out uint result);
            Assert.True(success);
            Assert.AreEqual(testValue, result);

            Assert.AreEqual(testValue, value.As<uint>());
            Assert.AreEqual(testValue, (uint)value);
        }

        [Test]
        public void NullableUIntInUIntOut([ValueSource("UInt32Data")] uint? testValue)
        {
            uint? source = testValue;
            Value value = new(source);

            bool success = value.TryGetValue(out uint result);
            Assert.True(success);
            Assert.AreEqual(testValue, result);

            Assert.AreEqual(testValue, value.As<uint>());

            Assert.AreEqual(testValue, (uint)value);
        }

        [Test]
        public void UIntInNullableUIntOut([ValueSource("UInt32Data")] uint testValue)
        {
            uint source = testValue;
            Value value = new(source);
            bool success = value.TryGetValue(out uint? result);
            Assert.True(success);
            Assert.AreEqual(testValue, result);

            Assert.AreEqual(testValue, (uint?)value);
        }

        [Test]
        public void BoxedUInt([ValueSource("UInt32Data")] uint testValue)
        {
            uint i = testValue;
            object o = i;
            Value value = new(o);

            Assert.AreEqual(typeof(uint), value.Type);
            Assert.True(value.TryGetValue(out uint result));
            Assert.AreEqual(testValue, result);
            Assert.True(value.TryGetValue(out uint? nullableResult));
            Assert.AreEqual(testValue, nullableResult!.Value);

            uint? n = testValue;
            o = n;
            value = new(o);

            Assert.AreEqual(typeof(uint), value.Type);
            Assert.True(value.TryGetValue(out result));
            Assert.AreEqual(testValue, result);
            Assert.True(value.TryGetValue(out nullableResult));
            Assert.AreEqual(testValue, nullableResult!.Value);
        }

        [Test]
        public void NullUInt()
        {
            uint? source = null;
            Value value = source;
            Assert.Null(value.Type);
            Assert.AreEqual(source, value.As<uint?>());
            Assert.False(value.As<uint?>().HasValue);
        }

        [Test]
        public void OutAsObject([ValueSource("UInt32Data")] uint testValue)
        {
            Value value = new(testValue);
            object o = value.As<object>();
            Assert.AreEqual(typeof(uint), o.GetType());
            Assert.AreEqual(testValue, (uint)o);

            uint? n = testValue;
            value = new(n);
            o = value.As<object>();
            Assert.AreEqual(typeof(uint), o.GetType());
            Assert.AreEqual(testValue, (uint)o);
        }
    }
}
