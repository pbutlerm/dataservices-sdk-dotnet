/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.AutoScaling.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeTagsResult Unmarshaller
     /// </summary>
    internal class DescribeTagsResultUnmarshaller : IUnmarshaller<DescribeTagsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeTagsResult, JsonUnmarshallerContext> 
    {
        public DescribeTagsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeTagsResult describeTagsResult = new DescribeTagsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Tags/member", targetDepth))
                    {
                        describeTagsResult.Tags.Add(TagDescriptionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("NextToken", targetDepth))
                    {
                        describeTagsResult.NextToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeTagsResult;
                }
            }
                        


            return describeTagsResult;
        }

        public DescribeTagsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeTagsResultUnmarshaller instance;

        public static DescribeTagsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeTagsResultUnmarshaller();

            return instance;
        }
    }
}
    
