using Logic.Networks;
using System.Net;

namespace Logic.Tests.Networks;

public class CidrSubnetTest
{
    [Fact]
    public void CalculateSubnetRangeIPv6Test()
    {
        // check with https://www.vultr.com/resources/subnet-calculator-ipv6 & https://dnschecker.org/ipv6-cidr-to-range.php

        // 1
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/128");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7334"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7334"));
        }

        // 2
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/127");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7334"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7335"));
        }

        // 4
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/126");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7334"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7337"));
        }

        // 8
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/125");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7330"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7337"));
        }

        // 16
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/124");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7330"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:733f"));
        }

        // 32
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/123");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7320"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:733f"));
        }

        // 64
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/122");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7300"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:733f"));
        }

        // 128
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/121");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7300"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:737f"));
        }

        // 256
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/120");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7300"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:73ff"));
        }

        // 512
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/119");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7200"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:73ff"));
        }

        // 1,024
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/118");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7000"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:73ff"));
        }

        // 2,048
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/117");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7000"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:77ff"));
        }

        // 4,096
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/116");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7000"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7fff"));
        }

        // 8,192
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/115");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:6000"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7fff"));
        }

        // 16,384
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/114");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:4000"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7fff"));
        }

        // 32,768
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/113");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:7fff"));
        }

        // 65,536
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/112");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:ffff"));
        }

        // 131,072
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/111");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:371:ffff"));
        }

        // 262,144
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/110");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:373:ffff"));
        }

        // 524,288
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/109");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:377:ffff"));
        }

        // 1,048,576
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/108");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:370:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:37f:ffff"));
        }

        // 2,097,152
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/107");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:360:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:37f:ffff"));
        }

        // 4,194,304
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/106");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:340:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:37f:ffff"));
        }

        // 8,388,608
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/105");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:300:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:37f:ffff"));
        }

        // 16,777,216
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/104");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:300:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:3ff:ffff"));
        }

        // 33,554,432
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/103");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:200:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:3ff:ffff"));
        }

        // 67,108,864
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/102");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:3ff:ffff"));
        }

        // 134,217,728
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/101");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:7ff:ffff"));
        }

        // 268,435,456
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/100");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:fff:ffff"));
        }

        // 536,870,912
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/99");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:1fff:ffff"));
        }

        // 1,073,741,824
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/98");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:3fff:ffff"));
        }

        // 2,147,483,648
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/97");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:7fff:ffff"));
        }

        // 4,294,967,296
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/96");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:ffff:ffff"));
        }

        // 8,589,934,592
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/95");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2e:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2f:ffff:ffff"));
        }

        // 17,179,869,184
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/94");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2c:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2f:ffff:ffff"));
        }

        // 34,359,738,368
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/93");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a28:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2f:ffff:ffff"));
        }

        // 68,719,476,736
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/92");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a20:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a2f:ffff:ffff"));
        }

        // 137,438,953,472
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/91");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a20:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a3f:ffff:ffff"));
        }

        // 274,877,906,944
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/90");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a00:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a3f:ffff:ffff"));
        }

        // 549,755,813,888
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/89");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a00:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a7f:ffff:ffff"));
        }

        // 1,099,511,627,776
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/88");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a00:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8aff:ffff:ffff"));
        }

        // 2,199,023,255,552
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/87");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8a00:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8bff:ffff:ffff"));
        }

        // 4,398,046,511,104
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/86");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8800:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8bff:ffff:ffff"));
        }

        // 8,796,093,022,208
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/85");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8800:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8fff:ffff:ffff"));
        }

        // 17,592,186,044,416
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/84");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8000:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8fff:ffff:ffff"));
        }

        // 35,184,372,088,832
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/83");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8000:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::9fff:ffff:ffff"));
        }

        // 70,368,744,177,664
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/82");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8000:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::bfff:ffff:ffff"));
        }

        // 140,737,488,355,328
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/81");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::8000:0:0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::ffff:ffff:ffff"));
        }

        // 281,474,976,710,656
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/80");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::ffff:ffff:ffff"));
        }

        // 562,949,953,421,312
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/79");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::1:ffff:ffff:ffff"));
        }

        // 1,125,899,906,842,624
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/78");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::3:ffff:ffff:ffff"));
        }

        // 2,251,799,813,685,248
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/77");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::7:ffff:ffff:ffff"));
        }

        // 4,503,599,627,370,496
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/76");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::f:ffff:ffff:ffff"));
        }

        // 9,007,199,254,740,992
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/75");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::1f:ffff:ffff:ffff"));
        }

        // 18,014,398,509,481,984
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/74");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::3f:ffff:ffff:ffff"));
        }

        // 36,028,797,018,963,968
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/73");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::7f:ffff:ffff:ffff"));
        }

        // 72,057,594,037,927,936
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/72");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::ff:ffff:ffff:ffff"));
        }

        // 144,115,188,075,855,872
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/71");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::1ff:ffff:ffff:ffff"));
        }

        // 288,230,376,151,711,744
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/70");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::3ff:ffff:ffff:ffff"));
        }

        // 576,460,752,303,423,488
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/69");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::7ff:ffff:ffff:ffff"));
        }

        // 1,152,921,504,606,846,976
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/68");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::fff:ffff:ffff:ffff"));
        }

        // 2,305,843,009,213,693,952
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/67");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::1fff:ffff:ffff:ffff"));
        }

        // 94,611,686,018,427,387,904
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/66");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::3fff:ffff:ffff:ffff"));
        }

        // 9,223,372,036,854,775,808
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/65");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::7fff:ffff:ffff:ffff"));
        }

        // 18,446,744,073,709,551,616
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/64");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:0:ffff:ffff:ffff:ffff"));
        }

        // 36,893,488,147,419,103,232
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/63");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:1:ffff:ffff:ffff:ffff"));
        }

        // 73,786,976,294,838,206,464
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/62");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:3:ffff:ffff:ffff:ffff"));
        }

        // 147,573,952,589,676,412,928
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/61");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:7:ffff:ffff:ffff:ffff"));
        }

        // 295,147,905,179,352,825,856
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/60");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:f:ffff:ffff:ffff:ffff"));
        }

        // 590,295,810,358,705,651,712
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/59");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:1f:ffff:ffff:ffff:ffff"));
        }

        // 1,180,591,620,717,411,303,424
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/58");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:3f:ffff:ffff:ffff:ffff"));
        }

        // 2,361,183,241,434,822,606,848
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/57");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:7f:ffff:ffff:ffff:ffff"));
        }

        // 4,722,366,482,869,645,213,696
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/56");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:ff:ffff:ffff:ffff:ffff"));
        }

        // 9,444,732,965,739,290,427,392
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/55");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:1ff:ffff:ffff:ffff:ffff"));
        }

        // 18,889,465,931,478,580,854,784
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/54");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:3ff:ffff:ffff:ffff:ffff"));
        }

        // 37,778,931,862,957,161,709,568
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/53");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:7ff:ffff:ffff:ffff:ffff"));
        }

        // 75,557,863,725,914,323,419,136
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/52");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:fff:ffff:ffff:ffff:ffff"));
        }

        // 151,115,727,451,828,646,838,272
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/51");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:1fff:ffff:ffff:ffff:ffff"));
        }

        // 302,231,454,903,657,293,676,544
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/50");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:3fff:ffff:ffff:ffff:ffff"));
        }

        // 604,462,909,807,314,587,353,088
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/49");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:7fff:ffff:ffff:ffff:ffff"));
        }

        // 1,208,925,819,614,629,174,706,176
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/48");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:ffff:ffff:ffff:ffff:ffff"));
        }

        // 2,417,851,639,229,258,349,412,352
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/47");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a2::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:ffff:ffff:ffff:ffff:ffff"));
        }

        // 4,835,703,278,458,516,698,824,704
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/46");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a0::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:ffff:ffff:ffff:ffff:ffff"));
        }

        // 9,671,406,556,917,033,397,649,408
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/45");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a0::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a7:ffff:ffff:ffff:ffff:ffff"));
        }

        // 19,342,813,113,834,066,795,298,816
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/44");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a0::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85af:ffff:ffff:ffff:ffff:ffff"));
        }

        // 38,685,626,227,668,133,590,597,632
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/43");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a0::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85bf:ffff:ffff:ffff:ffff:ffff"));
        }

        // 77,371,252,455,336,267,181,195,264
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/42");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8580::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85bf:ffff:ffff:ffff:ffff:ffff"));
        }

        // 154,742,504,910,672,534,362,390,528
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/41");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8580::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85ff:ffff:ffff:ffff:ffff:ffff"));
        }
        // 309,485,009,821,345,068,724,781,056
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/40");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8500::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85ff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 618,970,019,642,690,137,449,562,112
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/39");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8400::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85ff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 1,237,940,039,285,380,274,899,124,224
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/38");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8400::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:87ff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 2,475,880,078,570,760,549,798,248,448
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/37");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:87ff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 4,951,760,157,141,521,099,596,496,896
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/36");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:8fff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 9,903,520,314,283,042,199,192,993,792
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/35");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:9fff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 19,807,040,628,566,084,398,385,987,584
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/34");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:bfff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 39,614,081,257,132,168,796,771,975,168
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/33");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 79,228,162,514,264,337,593,543,950,336
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/32");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 158,456,325,028,528,675,187,087,900,672
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/31");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db9:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 316,912,650,057,057,350,374,175,801,344
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/30");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:dbb:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 633,825,300,114,114,700,748,351,602,688
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/29");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:dbf:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 1,267,650,600,228,229,401,496,703,205,376
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/28");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db0::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:dbf:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 2,535,301,200,456,458,802,993,406,410,752
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/27");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:da0::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:dbf:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 5,070,602,400,912,917,605,986,812,821,504
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/26");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:d80::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:dbf:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 10,141,204,801,825,835,211,973,625,643,008
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/25");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:d80::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:dff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 20,282,409,603,651,670,423,947,251,286,016
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/24");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:d00::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:dff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 40,564,819,207,303,340,847,894,502,572,032
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/23");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:c00::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:dff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 81,129,638,414,606,681,695,789,005,144,064
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/22");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:c00::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:fff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 162,259,276,829,213,363,391,578,010,288,128
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/21");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:800::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:fff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 324,518,553,658,426,726,783,156,020,576,256
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/20");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:fff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 649,037,107,316,853,453,566,312,041,152,512
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/19");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:1fff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 1,298,074,214,633,706,907,132,624,082,305,024
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/18");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:3fff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 2,596,148,429,267,413,814,265,248,164,610,048
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/17");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:7fff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 5,192,296,858,534,827,628,530,496,329,220,096
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/16");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 10,384,593,717,069,655,257,060,992,658,440,192
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/15");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 20,769,187,434,139,310,514,121,985,316,880,384
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/14");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2003:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 41,538,374,868,278,621,028,243,970,633,760,768
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/13");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2007:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 83,076,749,736,557,242,056,487,941,267,521,536
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/12");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("200f:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 166,153,499,473,114,484,112,975,882,535,043,072
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/11");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("201f:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 332,306,998,946,228,968,225,951,765,070,086,144
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/10");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("203f:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 664,613,997,892,457,936,451,903,530,140,172,288
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/9");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("207f:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 1,329,227,995,784,915,872,903,807,060,280,344,576
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/8");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("20ff:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 2,658,455,991,569,831,745,807,614,120,560,689,152
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/7");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("21ff:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 5,316,911,983,139,663,491,615,228,241,121,378,304
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/6");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("23ff:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 10,633,823,966,279,326,983,230,456,482,242,756,608
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/5");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("27ff:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 21,267,647,932,558,653,966,460,912,964,485,513,216
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/4");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2fff:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 42,535,295,865,117,307,932,921,825,928,971,026,432
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/3");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2000::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("3fff:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 85,070,591,730,234,615,865,843,651,857,942,052,864
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/2");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("3fff:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }

        // 170,141,183,460,469,231,731,687,303,715,884,105,728
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334/1");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("7fff:ffff:ffff:ffff:ffff:ffff:ffff:ffff"));
        }
    }

    [Fact]
    public void CalculateSubnetRangeIPv4Test()
    {
        // check with https://www.softel.co.jp/labs/tools/network/

        // 1
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.150.121/32");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.150.121"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.150.121"));
        }

        // 2
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.140.111/31");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.140.110"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.140.111"));
        }

        // 4
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.130.90/30");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.130.88"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.130.91"));
        }

        // 8
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.100.101/29");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.100.96"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.100.103"));
        }

        // 16
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.120.200/28");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.120.192"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.120.207"));
        }

        // 32
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.90.50/27");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.90.32"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.90.63"));
        }

        // 64
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.80.30/26");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.80.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.80.63"));
        }

        // 128
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.70.30/25");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.70.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.70.127"));
        }

        // 256
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.60.1/24");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.60.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.60.255"));
        }

        // 512
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30/23");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.50.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.51.255"));
        }

        // 1024
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30/22");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.48.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.51.255"));
        }

        // 2048
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30/21");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.48.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.55.255"));
        }

        // 4096
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30/20");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.48.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.63.255"));
        }

        // 8192
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30/19");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.32.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.63.255"));
        }

        // 16384
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30/18");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.63.255"));
        }

        // 32768
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30/17");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.127.255"));
        }

        // 65536
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("172.16.40.30/16");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("172.16.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("172.16.255.255"));
        }

        // 131072
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("10.1.100.30/15");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("10.0.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("10.1.255.255"));
        }

        // 262144
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("10.1.100.30/14");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("10.0.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("10.3.255.255"));
        }

        // 524288
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("10.1.100.30/13");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("10.0.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("10.7.255.255"));
        }

        // 1048576
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("10.1.100.30/12");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("10.0.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("10.15.255.255"));
        }

        // 2097152
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("10.1.100.30/11");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("10.0.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("10.31.255.255"));
        }

        // 4194304
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("10.1.100.30/10");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("10.0.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("10.63.255.255"));
        }

        // 8388608
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("10.1.100.30/9");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("10.0.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("10.127.255.255"));
        }

        // 16777216
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("10.1.100.30/8");
            addressRange.StartAddress.Should().Be(IPAddress.Parse("10.0.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("10.255.255.255"));
        }
    }

    [Fact]
    public void CalculateSubnetRangeIPv6OverloadTest()
    {
        var addresses = new[] {
            "2001:0db8:85a3::8a2e:0370:7334",
            "2001:db8::1",
            "2001:0db8:0001:0000:0000:0ab9:C0A8:0102",
            "2001:db8:3333:4444:5555:6666:1.2.3.4",
            "2001:db8::123.123.123.123",
        };
        var subnets = Enumerable.Range(32, 32 + 1); // サブネットに分割するビット数。42-64までチェックする。
        foreach (var address in addresses)
        {
            foreach (var subnet in subnets)
            {
                var (startAddress, endAddress) = CidrSubnet.CalculateSubnetRange(address, subnet);
                var (startAddress2, endAddress2) = CidrSubnet.CalculateSubnetRange($"{address}/{subnet}");
                startAddress.Should().Be(startAddress2);
                endAddress.Should().Be(endAddress2);

                var (startAddress3, endAddress3) = CidrSubnet.CalculateSubnetRange2(address, subnet);
                var (startAddress4, endAddress4) = CidrSubnet.CalculateSubnetRange2($"{address}/{subnet}");
                startAddress3.Should().Be(startAddress4);
                endAddress3.Should().Be(endAddress4);
            }
        }
    }

    [Fact]
    public void CalculateSubnetRangeIPv4OverloadTest()
    {
        var addresses = new[] {
            "192.168.1.1",
            "172.16.20.100",
            "10.1.0.20",
            "192.168.50.1",
        };
        var subnets = Enumerable.Range(8, 24 + 1); // サブネットに分割するビット数。8-32までチェックする。
        foreach (var address in addresses)
        {
            foreach (var subnet in subnets)
            {
                var (startAddress, endAddress) = CidrSubnet.CalculateSubnetRange(address, subnet);
                var (startAddress2, endAddress2) = CidrSubnet.CalculateSubnetRange($"{address}/{subnet}");
                startAddress.Should().Be(startAddress2);
                endAddress.Should().Be(endAddress2);

                var (startAddress3, endAddress3) = CidrSubnet.CalculateSubnetRange2(address, subnet);
                var (startAddress4, endAddress4) = CidrSubnet.CalculateSubnetRange2($"{address}/{subnet}");
                startAddress3.Should().Be(startAddress4);
                endAddress3.Should().Be(endAddress4);
            }
        }
    }

    [Fact]
    public void CalculateSubnetRangeIPv6EqualityTest()
    {
        var addresses = new[] {
            "2001:0db8:85a3::8a2e:0370:7334",
            "2001:db8::1",
            "2001:0db8:0001:0000:0000:0ab9:C0A8:0102",
            "2001:db8:3333:4444:5555:6666:1.2.3.4",
            "2001:db8::123.123.123.123",
        };
        var subnets = Enumerable.Range(32, 32 + 1); // サブネットに分割するビット数。42-64までチェックする。
        foreach (var address in addresses)
        {
            foreach (var subnet in subnets)
            {
                var (startAddress, endAddress) = CidrSubnet.CalculateSubnetRange(address, subnet);
                var (startAddress2, endAddress2) = CidrSubnet.CalculateSubnetRange2(address, subnet);
                startAddress.Should().Be(startAddress2);
                endAddress.Should().Be(endAddress2);
            }
        }
    }

    [Fact]
    public void CalculateSubnetRangeIPv4EqualityTest()
    {
        var addresses = new[] {
            "192.168.1.1",
            "172.16.20.100",
            "10.1.0.20",
            "192.168.50.1",
        };
        var subnets = Enumerable.Range(8, 24 + 1); // サブネットに分割するビット数。8-32までチェックする。
        foreach (var address in addresses)
        {
            foreach (var subnet in subnets)
            {
                var (startAddress, endAddress) = CidrSubnet.CalculateSubnetRange(address, subnet);
                var (startAddress2, endAddress2) = CidrSubnet.CalculateSubnetRange2(address, subnet);
                startAddress.Should().Be(startAddress2);
                endAddress.Should().Be(endAddress2);
            }
        }
    }
}
