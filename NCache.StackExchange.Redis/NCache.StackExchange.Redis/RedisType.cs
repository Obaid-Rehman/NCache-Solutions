﻿//Copyright(c) 2014 Stack Exchange

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

//===============================================

namespace NCache.StackExchange.Redis
{
    /// <summary>
    /// The intrinsinc data-types supported by redis
    /// </summary>
    /// <remarks>https://redis.io/topics/data-types</remarks>
    public enum RedisType
    {
        /// <summary>
        /// The specified key does not exist
        /// </summary>
        None,
        /// <summary>
        /// Strings are the most basic kind of Redis value. Redis Strings are binary safe, this means that a Redis string can contain any kind of data, for instance a JPEG image or a serialized Ruby object.
        /// A String value can be at max 512 Megabytes in length.
        /// </summary>
        /// <remarks>https://redis.io/commands#string</remarks>
        String,
        /// <summary>
        /// Redis Lists are simply lists of strings, sorted by insertion order. It is possible to add elements to a Redis List pushing new elements on the head (on the left) or on the tail (on the right) of the list.
        /// </summary>
        /// <remarks>https://redis.io/commands#list</remarks>
        List,
        /// <summary>
        /// Redis Sets are an unordered collection of Strings. It is possible to add, remove, and test for existence of members in O(1) (constant time regardless of the number of elements contained inside the Set).
        /// Redis Sets have the desirable property of not allowing repeated members. Adding the same element multiple times will result in a set having a single copy of this element. Practically speaking this means that adding a member does not require a check if exists then add operation.
        /// </summary>
        /// <remarks>https://redis.io/commands#set</remarks>
        Set,
        /// <summary>
        /// Redis Sorted Sets are, similarly to Redis Sets, non repeating collections of Strings. The difference is that every member of a Sorted Set is associated with score, that is used in order to take the sorted set ordered, from the smallest to the greatest score. While members are unique, scores may be repeated.
        /// </summary>
        /// <remarks>https://redis.io/commands#sorted_set</remarks>
        SortedSet,
        /// <summary>
        /// Redis Hashes are maps between string fields and string values, so they are the perfect data type to represent objects (eg: A User with a number of fields like name, surname, age, and so forth)
        /// </summary>
        /// <remarks>https://redis.io/commands#hash</remarks>
        Hash,
        /// <summary>
        /// A Redis Stream is a data structure which models the behavior of an append only log but it has more
        /// advanced features for manipulating the data contained within the stream. Each entry in a
        /// stream contains a unique message ID and a list of name/value pairs containing the entry's data.
        /// </summary>
        /// <remarks>https://redis.io/commands#stream</remarks>
        Stream,
        /// <summary>
        /// The data-type was not recognised by the client library
        /// </summary>
        Unknown,
    }
}
