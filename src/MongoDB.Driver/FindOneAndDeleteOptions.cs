﻿/* Copyright 2010-2014 MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson.Serialization;
using MongoDB.Driver.Core.Misc;

namespace MongoDB.Driver
{
    /// <summary>
    /// Options for a findAndModify command to delete an object.
    /// </summary>
    public class FindOneAndDeleteOptions<TResult>
    {
        // fields
        private TimeSpan? _maxTime;
        private object _projection;
        private IBsonSerializer<TResult> _resultSerializer;
        private object _sort;

        // properties
        /// <summary>
        /// Gets or sets the maximum time.
        /// </summary>
        public TimeSpan? MaxTime
        {
            get { return _maxTime; }
            set { _maxTime = value; }
        }

        /// <summary>
        /// Gets or sets the projection.
        /// </summary>
        public object Projection
        {
            get { return _projection; }
            set { _projection = value; }
        }

        /// <summary>
        /// Gets or sets the result serializer.
        /// </summary>
        public IBsonSerializer<TResult> ResultSerializer
        {
            get { return _resultSerializer; }
            set { _resultSerializer = value; }
        }

        /// <summary>
        /// Gets or sets the sort.
        /// </summary>
        public object Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }
    }
}