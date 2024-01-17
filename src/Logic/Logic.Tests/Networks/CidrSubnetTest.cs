using Logic.Networks;
using System.Net;

namespace Logic.Tests.Networks;

public class CidrSubnetTest
{
    // GetNthSubnet

    // check with terraform function `cidrsubnet(cidr, newbits, newnum)` https://developer.hashicorp.com/terraform/language/functions/cidrsubnet

    [Theory]
    [InlineData("2001:db8::/56", 8, 0, "2001:db8::/64")]
    [InlineData("2001:db8::/56", 8, 1, "2001:db8:0:1::/64")]
    [InlineData("2001:db8::/56", 8, 2, "2001:db8:0:2::/64")]
    [InlineData("2001:db8::/56", 8, 3, "2001:db8:0:3::/64")]
    [InlineData("2001:db8::/56", 8, 4, "2001:db8:0:4::/64")]
    [InlineData("2001:db8::/56", 10, 0, "2001:db8::/66")]
    [InlineData("2001:db8::/56", 10, 1, "2001:db8:0:0:4000::/66")]
    [InlineData("2001:db8::/56", 10, 2, "2001:db8:0:0:8000::/66")]
    [InlineData("2001:db8::/56", 10, 3, "2001:db8:0:0:c000::/66")]
    [InlineData("2001:db8::/56", 10, 4, "2001:db8:0:1::/66")]
    [InlineData("fd00:fd12:3456:7890::/56", 16, 162, "fd00:fd12:3456:7800:a200::/72")] 
    public void GetNthSubnetIPv6Test(string cidr, int newbits, int netnum, string expectedAddress)
    {
        var actual = CidrSubnet.GetNthSubnet(cidr, newbits, netnum);
        actual.Should().Be(expectedAddress);
    }

    [Theory]
    [InlineData("172.16.0.0/16", 8, 0, "172.16.0.0/24")]
    [InlineData("172.16.0.0/16", 8, 1, "172.16.1.0/24")]
    [InlineData("172.16.0.0/16", 8, 2, "172.16.2.0/24")]
    [InlineData("172.16.0.0/16", 8, 3, "172.16.3.0/24")]
    [InlineData("172.16.0.0/16", 8, 4, "172.16.4.0/24")]
    [InlineData("172.16.0.0/16", 10, 0, "172.16.0.0/26")]
    [InlineData("172.16.0.0/16", 10, 1, "172.16.0.64/26")]
    [InlineData("172.16.0.0/16", 10, 2, "172.16.0.128/26")]
    [InlineData("172.16.0.0/16", 10, 3, "172.16.0.192/26")]
    [InlineData("172.16.0.0/16", 10, 4, "172.16.1.0/26")]
    [InlineData("172.16.0.0/12", 4, 2, "172.18.0.0/16")]
    [InlineData("10.1.2.0/24", 4, 15, "10.1.2.240/28")]
    public void GetNthSubnetIPv4Test(string cidr, int newbits, int netnum, string expectedAddress)
    {
        var actual = CidrSubnet.GetNthSubnet(cidr, newbits, netnum);
        actual.Should().Be(expectedAddress);
    }

    // GetSubnetRangeSlow

    // check with https://www.vultr.com/resources/subnet-calculator-ipv6 & https://dnschecker.org/ipv6-cidr-to-range.php
    [Theory]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/128", "2001:db8:85a3::8a2e:370:7334", "2001:db8:85a3::8a2e:370:7334")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/127", "2001:db8:85a3::8a2e:370:7334", "2001:db8:85a3::8a2e:370:7335")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/126", "2001:db8:85a3::8a2e:370:7334", "2001:db8:85a3::8a2e:370:7337")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/125", "2001:db8:85a3::8a2e:370:7330", "2001:db8:85a3::8a2e:370:7337")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/124", "2001:db8:85a3::8a2e:370:7330", "2001:db8:85a3::8a2e:370:733f")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/123", "2001:db8:85a3::8a2e:370:7320", "2001:db8:85a3::8a2e:370:733f")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/122", "2001:db8:85a3::8a2e:370:7300", "2001:db8:85a3::8a2e:370:733f")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/121", "2001:db8:85a3::8a2e:370:7300", "2001:db8:85a3::8a2e:370:737f")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/120", "2001:db8:85a3::8a2e:370:7300", "2001:db8:85a3::8a2e:370:73ff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/119", "2001:db8:85a3::8a2e:370:7200", "2001:db8:85a3::8a2e:370:73ff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/118", "2001:db8:85a3::8a2e:370:7000", "2001:db8:85a3::8a2e:370:73ff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/117", "2001:db8:85a3::8a2e:370:7000", "2001:db8:85a3::8a2e:370:77ff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/116", "2001:db8:85a3::8a2e:370:7000", "2001:db8:85a3::8a2e:370:7fff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/115", "2001:db8:85a3::8a2e:370:6000", "2001:db8:85a3::8a2e:370:7fff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/114", "2001:db8:85a3::8a2e:370:4000", "2001:db8:85a3::8a2e:370:7fff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/113", "2001:db8:85a3::8a2e:370:0", "2001:db8:85a3::8a2e:370:7fff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/112", "2001:db8:85a3::8a2e:370:0", "2001:db8:85a3::8a2e:370:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/111", "2001:db8:85a3::8a2e:370:0", "2001:db8:85a3::8a2e:371:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/110", "2001:db8:85a3::8a2e:370:0", "2001:db8:85a3::8a2e:373:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/109", "2001:db8:85a3::8a2e:370:0", "2001:db8:85a3::8a2e:377:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/108", "2001:db8:85a3::8a2e:370:0", "2001:db8:85a3::8a2e:37f:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/107", "2001:db8:85a3::8a2e:360:0", "2001:db8:85a3::8a2e:37f:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/106", "2001:db8:85a3::8a2e:340:0", "2001:db8:85a3::8a2e:37f:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/105", "2001:db8:85a3::8a2e:300:0", "2001:db8:85a3::8a2e:37f:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/104", "2001:db8:85a3::8a2e:300:0", "2001:db8:85a3::8a2e:3ff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/103", "2001:db8:85a3::8a2e:200:0", "2001:db8:85a3::8a2e:3ff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/102", "2001:db8:85a3::8a2e:0:0", "2001:db8:85a3::8a2e:3ff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/101", "2001:db8:85a3::8a2e:0:0", "2001:db8:85a3::8a2e:7ff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/100", "2001:db8:85a3::8a2e:0:0", "2001:db8:85a3::8a2e:fff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/99", "2001:db8:85a3::8a2e:0:0", "2001:db8:85a3::8a2e:1fff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/98", "2001:db8:85a3::8a2e:0:0", "2001:db8:85a3::8a2e:3fff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/97", "2001:db8:85a3::8a2e:0:0", "2001:db8:85a3::8a2e:7fff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/96", "2001:db8:85a3::8a2e:0:0", "2001:db8:85a3::8a2e:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/95", "2001:db8:85a3::8a2e:0:0", "2001:db8:85a3::8a2f:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/94", "2001:db8:85a3::8a2c:0:0", "2001:db8:85a3::8a2f:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/93", "2001:db8:85a3::8a28:0:0", "2001:db8:85a3::8a2f:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/92", "2001:db8:85a3::8a20:0:0", "2001:db8:85a3::8a2f:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/91", "2001:db8:85a3::8a20:0:0", "2001:db8:85a3::8a3f:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/90", "2001:db8:85a3::8a00:0:0", "2001:db8:85a3::8a3f:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/89", "2001:db8:85a3::8a00:0:0", "2001:db8:85a3::8a7f:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/88", "2001:db8:85a3::8a00:0:0", "2001:db8:85a3::8aff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/87", "2001:db8:85a3::8a00:0:0", "2001:db8:85a3::8bff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/86", "2001:db8:85a3::8800:0:0", "2001:db8:85a3::8bff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/85", "2001:db8:85a3::8800:0:0", "2001:db8:85a3::8fff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/84", "2001:db8:85a3::8000:0:0", "2001:db8:85a3::8fff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/83", "2001:db8:85a3::8000:0:0", "2001:db8:85a3::9fff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/82", "2001:db8:85a3::8000:0:0", "2001:db8:85a3::bfff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/81", "2001:db8:85a3::8000:0:0", "2001:db8:85a3::ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/80", "2001:db8:85a3::", "2001:db8:85a3::ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/79", "2001:db8:85a3::", "2001:db8:85a3::1:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/78", "2001:db8:85a3::", "2001:db8:85a3::3:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/77", "2001:db8:85a3::", "2001:db8:85a3::7:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/76", "2001:db8:85a3::", "2001:db8:85a3::f:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/75", "2001:db8:85a3::", "2001:db8:85a3::1f:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/74", "2001:db8:85a3::", "2001:db8:85a3::3f:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/73", "2001:db8:85a3::", "2001:db8:85a3::7f:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/72", "2001:db8:85a3::", "2001:db8:85a3::ff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/71", "2001:db8:85a3::", "2001:db8:85a3::1ff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/70", "2001:db8:85a3::", "2001:db8:85a3::3ff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/69", "2001:db8:85a3::", "2001:db8:85a3::7ff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/68", "2001:db8:85a3::", "2001:db8:85a3::fff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/67", "2001:db8:85a3::", "2001:db8:85a3::1fff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/66", "2001:db8:85a3::", "2001:db8:85a3::3fff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/65", "2001:db8:85a3::", "2001:db8:85a3::7fff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/64", "2001:db8:85a3::", "2001:db8:85a3:0:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/63", "2001:db8:85a3::", "2001:db8:85a3:1:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/62", "2001:db8:85a3::", "2001:db8:85a3:3:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/61", "2001:db8:85a3::", "2001:db8:85a3:7:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/60", "2001:db8:85a3::", "2001:db8:85a3:f:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/59", "2001:db8:85a3::", "2001:db8:85a3:1f:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/58", "2001:db8:85a3::", "2001:db8:85a3:3f:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/57", "2001:db8:85a3::", "2001:db8:85a3:7f:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/56", "2001:db8:85a3::", "2001:db8:85a3:ff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/55", "2001:db8:85a3::", "2001:db8:85a3:1ff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/54", "2001:db8:85a3::", "2001:db8:85a3:3ff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/53", "2001:db8:85a3::", "2001:db8:85a3:7ff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/52", "2001:db8:85a3::", "2001:db8:85a3:fff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/51", "2001:db8:85a3::", "2001:db8:85a3:1fff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/50", "2001:db8:85a3::", "2001:db8:85a3:3fff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/49", "2001:db8:85a3::", "2001:db8:85a3:7fff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/48", "2001:db8:85a3::", "2001:db8:85a3:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/47", "2001:db8:85a2::", "2001:db8:85a3:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/46", "2001:db8:85a0::", "2001:db8:85a3:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/45", "2001:db8:85a0::", "2001:db8:85a7:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/44", "2001:db8:85a0::", "2001:db8:85af:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/43", "2001:db8:85a0::", "2001:db8:85bf:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/42", "2001:db8:8580::", "2001:db8:85bf:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/41", "2001:db8:8580::", "2001:db8:85ff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/40", "2001:db8:8500::", "2001:db8:85ff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/39", "2001:db8:8400::", "2001:db8:85ff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/38", "2001:db8:8400::", "2001:db8:87ff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/37", "2001:db8:8000::", "2001:db8:87ff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/36", "2001:db8:8000::", "2001:db8:8fff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/35", "2001:db8:8000::", "2001:db8:9fff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/34", "2001:db8:8000::", "2001:db8:bfff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/33", "2001:db8:8000::", "2001:db8:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/32", "2001:db8::", "2001:db8:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/31", "2001:db8::", "2001:db9:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/30", "2001:db8::", "2001:dbb:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/29", "2001:db8::", "2001:dbf:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/28", "2001:db0::", "2001:dbf:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/27", "2001:da0::", "2001:dbf:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/26", "2001:d80::", "2001:dbf:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/25", "2001:d80::", "2001:dff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/24", "2001:d00::", "2001:dff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/23", "2001:c00::", "2001:dff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/22", "2001:c00::", "2001:fff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/21", "2001:800::", "2001:fff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/20", "2001::", "2001:fff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/19", "2001::", "2001:1fff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/18", "2001::", "2001:3fff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/17", "2001::", "2001:7fff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/16", "2001::", "2001:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/15", "2000::", "2001:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/14", "2000::", "2003:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/13", "2000::", "2007:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/12", "2000::", "200f:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/11", "2000::", "201f:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/10", "2000::", "203f:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/9", "2000::", "207f:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/8", "2000::", "20ff:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/7", "2000::", "21ff:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/6", "2000::", "23ff:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/5", "2000::", "27ff:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/4", "2000::", "2fff:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/3", "2000::", "3fff:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/2", "::", "3fff:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    [InlineData("2001:0db8:85a3::8a2e:0370:7334/1", "::", "7fff:ffff:ffff:ffff:ffff:ffff:ffff:ffff")]
    public void GetSubnetRangeIPv6Test(string cidr, string expectedStartAddress, string expectedEndAddress)
    {
        var (startAddress, endAddress) = CidrSubnet.GetSubnetRangeSlow(cidr);
        startAddress.Should().Be(IPAddress.Parse(expectedStartAddress));
        endAddress.Should().Be(IPAddress.Parse(expectedEndAddress));
    }

    // check with https://www.softel.co.jp/labs/tools/network/
    [Theory]
    [InlineData("192.168.150.121/32", "192.168.150.121", "192.168.150.121")]
    [InlineData("192.168.140.111/31", "192.168.140.110", "192.168.140.111")]
    [InlineData("192.168.130.90/30", "192.168.130.88", "192.168.130.91")]
    [InlineData("192.168.100.101/29", "192.168.100.96", "192.168.100.103")]
    [InlineData("192.168.120.200/28", "192.168.120.192", "192.168.120.207")]
    [InlineData("192.168.90.50/27", "192.168.90.32", "192.168.90.63")]
    [InlineData("192.168.80.30/26", "192.168.80.0", "192.168.80.63")]
    [InlineData("192.168.70.30/25", "192.168.70.0", "192.168.70.127")]
    [InlineData("192.168.60.1/24", "192.168.60.0", "192.168.60.255")]
    [InlineData("192.168.50.30/23", "192.168.50.0", "192.168.51.255")]
    [InlineData("192.168.50.30/22", "192.168.48.0", "192.168.51.255")]
    [InlineData("192.168.50.30/21", "192.168.48.0", "192.168.55.255")]
    [InlineData("192.168.50.30/20", "192.168.48.0", "192.168.63.255")]
    [InlineData("192.168.50.30/19", "192.168.32.0", "192.168.63.255")]
    [InlineData("192.168.50.30/18", "192.168.0.0", "192.168.63.255")]
    [InlineData("192.168.50.30/17", "192.168.0.0", "192.168.127.255")]
    [InlineData("172.16.40.30/16", "172.16.0.0", "172.16.255.255")]
    [InlineData("10.1.100.30/15", "10.0.0.0", "10.1.255.255")]
    [InlineData("10.1.100.30/14", "10.0.0.0", "10.3.255.255")]
    [InlineData("10.1.100.30/13", "10.0.0.0", "10.7.255.255")]
    [InlineData("10.1.100.30/12", "10.0.0.0", "10.15.255.255")]
    [InlineData("10.1.100.30/11", "10.0.0.0", "10.31.255.255")]
    [InlineData("10.1.100.30/10", "10.0.0.0", "10.63.255.255")]
    [InlineData("10.1.100.30/9", "10.0.0.0", "10.127.255.255")]
    [InlineData("10.1.100.30/8", "10.0.0.0", "10.255.255.255")]
    public void GetSubnetRangeIPv4Test(string cidr, string expectedStartAddress, string expectedEndAddress)
    {
        var (startAddress, endAddress) = CidrSubnet.GetSubnetRangeSlow(cidr);
        startAddress.Should().Be(IPAddress.Parse(expectedStartAddress));
        endAddress.Should().Be(IPAddress.Parse(expectedEndAddress));
    }

    [Fact]
    public void GetSubnetRangeIPv6OverloadTest()
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
                var (startAddress, endAddress) = CidrSubnet.GetSubnetRangeSlow(address, subnet);
                var (startAddress2, endAddress2) = CidrSubnet.GetSubnetRangeSlow($"{address}/{subnet}");
                startAddress.Should().Be(startAddress2);
                endAddress.Should().Be(endAddress2);

                var (startAddress3, endAddress3) = CidrSubnet.GetSubnetRange(address, subnet);
                var (startAddress4, endAddress4) = CidrSubnet.GetSubnetRange($"{address}/{subnet}");
                startAddress3.Should().Be(startAddress4);
                endAddress3.Should().Be(endAddress4);
            }
        }
    }

    [Fact]
    public void GetSubnetRangeIPv4OverloadTest()
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
                var (startAddress, endAddress) = CidrSubnet.GetSubnetRangeSlow(address, subnet);
                var (startAddress2, endAddress2) = CidrSubnet.GetSubnetRangeSlow($"{address}/{subnet}");
                startAddress.Should().Be(startAddress2);
                endAddress.Should().Be(endAddress2);

                var (startAddress3, endAddress3) = CidrSubnet.GetSubnetRange(address, subnet);
                var (startAddress4, endAddress4) = CidrSubnet.GetSubnetRange($"{address}/{subnet}");
                startAddress3.Should().Be(startAddress4);
                endAddress3.Should().Be(endAddress4);
            }
        }
    }

    [Fact]
    public void GetSubnetRangeIPv6EqualityTest()
    {
        var addresses = new[] {
            "2001:0db8:85a3::8a2e:0370:7334",
            "2001:db8::1",
            "2001:0db8:0001:0000:0000:0ab9:C0A8:0102",
            "2001:db8:3333:4444:5555:6666:1.2.3.4",
            "2001:db8::123.123.123.123",
        };
        var subnets = Enumerable.Range(1, 128); // サブネットに分割するビット数。1-128までチェックする。
        foreach (var address in addresses)
        {
            foreach (var subnet in subnets)
            {
                var (startAddress, endAddress) = CidrSubnet.GetSubnetRangeSlow(address, subnet);
                var (startAddress2, endAddress2) = CidrSubnet.GetSubnetRange(address, subnet);
                startAddress.Should().Be(startAddress2);
                endAddress.Should().Be(endAddress2);
            }
        }
    }

    [Fact]
    public void GetSubnetRangeIPv4EqualityTest()
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
                var (startAddress, endAddress) = CidrSubnet.GetSubnetRangeSlow(address, subnet);
                var (startAddress2, endAddress2) = CidrSubnet.GetSubnetRange(address, subnet);
                startAddress.Should().Be(startAddress2);
                endAddress.Should().Be(endAddress2);
            }
        }
    }

    [Fact]
    public void GetSubnetRangeThrowTest()
    {
        // IPv4 Invalid CIDR format
        Assert.Throws<FormatException>(() => CidrSubnet.GetSubnetRangeSlow("255.255.255.256/32"));
        Assert.Throws<FormatException>(() => CidrSubnet.GetSubnetRange("255.255.255.256/32"));

        // IPv6 Invalid CIDR format
        Assert.Throws<FormatException>(() => CidrSubnet.GetSubnetRangeSlow("2001:db8:85a3::8a2e:/64"));
        Assert.Throws<FormatException>(() => CidrSubnet.GetSubnetRange("2001:db8:85a3::8a2e:/64"));

        // IPv4 Subnet allows 1-32
        Assert.Throws<ArgumentOutOfRangeException>(() => CidrSubnet.GetSubnetRangeSlow("192.168.1.1/0"));
        Assert.Throws<ArgumentOutOfRangeException>(() => CidrSubnet.GetSubnetRange("192.168.1.1/0"));
        Assert.Throws<ArgumentOutOfRangeException>(() => CidrSubnet.GetSubnetRangeSlow("192.168.1.1/33"));
        Assert.Throws<ArgumentOutOfRangeException>(() => CidrSubnet.GetSubnetRange("192.168.1.1/33"));

        // IPv6 Subnet allows 1-128
        Assert.Throws<ArgumentOutOfRangeException>(() => CidrSubnet.GetSubnetRangeSlow("2001:db8::1/0"));
        Assert.Throws<ArgumentOutOfRangeException>(() => CidrSubnet.GetSubnetRange("2001:db8::1/0"));
        Assert.Throws<ArgumentOutOfRangeException>(() => CidrSubnet.GetSubnetRangeSlow("2001:db8::1/129"));
        Assert.Throws<ArgumentOutOfRangeException>(() => CidrSubnet.GetSubnetRange("2001:db8::1/129"));
    }
}
