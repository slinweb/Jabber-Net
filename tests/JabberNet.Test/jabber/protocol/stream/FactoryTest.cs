/* --------------------------------------------------------------------------
 * Copyrights
 *
 * Portions created by or assigned to Cursive Systems, Inc. are
 * Copyright (c) 2002-2008 Cursive Systems, Inc.  All Rights Reserved.  Contact
 * information for Cursive Systems, Inc. is available at
 * http://www.cursive.net/.
 *
 * License
 *
 * Jabber-Net is licensed under the LGPL.
 * See licenses/Jabber-Net_LGPLv3.txt for details.
 * --------------------------------------------------------------------------*/

using JabberNet.jabber.protocol;
using NUnit.Framework;
using fact = JabberNet.jabber.protocol.stream.Factory;

namespace JabberNet.Test.jabber.protocol.stream
{
    /// <summary>
    /// Summary description for StreamFactoryTest.
    /// </summary>
    [TestFixture]
    public class StreamFactoryTest
    {
        [Test] public void Test_Create()
        {
            ElementFactory pf = new ElementFactory();
            pf.AddType(new fact());
        }
    }
}
