/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// This is the response object from the ListFunctions operation.
    /// </summary>
    public partial class ListFunctionsResponse : AmazonWebServiceResponse
    {
        private List<FunctionConfiguration> _functions = new List<FunctionConfiguration>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Functions. 
        /// <para>
        /// A list of <code>Function</code> objects.
        /// </para>
        /// </summary>
        public List<FunctionConfiguration> Functions
        {
            get { return this._functions; }
            set { this._functions = value; }
        }

        // Check to see if Functions property is set
        internal bool IsSetFunctions()
        {
            return this._functions != null && this._functions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}