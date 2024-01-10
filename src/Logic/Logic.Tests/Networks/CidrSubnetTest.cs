using Logic.Networks;
using System.Net;

namespace Logic.Tests.Networks;

public class CidrSubnetTest
{
    [Fact]
    public void CalculateSubnetRangeIPv6Test()
    {
        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:0001:0000:0000:0ab9:C0A8:0102", 64);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:1::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:1:0:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 64);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:0:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 63);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:1:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 62);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:3:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 61);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:7:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 60);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:f:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 59);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:1f:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 58);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:3f:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 57);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:7f:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 56);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:ff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 55);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:1ff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 54);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:3ff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 53);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:7ff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 52);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:fff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 51);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:1fff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 50);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:3fff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 49);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:7fff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 48);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a3::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:ffff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 47);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a2::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:ffff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 46);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a0::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a3:ffff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 45);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a0::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85a7:ffff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 44);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a0::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85af:ffff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 43);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:85a0::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85bf:ffff:ffff:ffff:ffff:ffff"));
        }

        {
            var addressRange = CidrSubnet.CalculateSubnetRange("2001:0db8:85a3::8a2e:0370:7334", 42);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("2001:db8:8580::"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("2001:db8:85bf:ffff:ffff:ffff:ffff:ffff"));
        }

    }

    [Fact]
    public void CalculateSubnetRangeIPv4Test()
    {
        {
            // (1) .121
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.150.121", 32);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.150.121"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.150.121"));
        }

        {
            // (2) .110 - .111
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.140.111", 31);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.140.110"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.140.111"));
        }

        {
            // (4) .88 - .91
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.130.90", 30);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.130.88"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.130.91"));
        }

        {
            // (8) .96 - .103
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.100.101", 29);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.100.96"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.100.103"));
        }

        {
            // (16) .192 - .207
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.120.200", 28);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.120.192"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.120.207"));
        }

        {
            // (32) .32 - .63
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.90.50", 27);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.90.32"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.90.63"));
        }

        {
            // (64) .0 - .63
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.80.30", 26);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.80.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.80.63"));
        }

        {
            // (128) .0 - .127
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.70.30", 25);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.70.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.70.127"));
        }

        {
            // (256) .0 - .255
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.60.1", 24);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.60.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.60.255"));
        }

        {
            // (512) .50.0 - .51.255
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30", 23);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.50.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.51.255"));
        }

        {
            // (1024) .48.0 - .51.255
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30", 22);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.48.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.51.255"));
        }

        {
            // (2048) .48.0 - .55.255
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30", 21);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.48.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.55.255"));
        }

        {
            // (4096) .48.0 - .63.255
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30", 20);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.48.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.63.255"));
        }

        {
            // (8192) .32.0 - .63.255
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30", 19);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.32.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.63.255"));
        }

        {
            // (16384) .32.0 - .63.255
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30", 18);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.63.255"));
        }

        {
            // (32768) .32.0 - .63.255
            var addressRange = CidrSubnet.CalculateSubnetRange("192.168.50.30", 17);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("192.168.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("192.168.127.255"));
        }

        {
            // (65536) .16.0.0 - .16.255.255
            var addressRange = CidrSubnet.CalculateSubnetRange("172.16.40.30", 16);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("172.16.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("172.16.255.255"));
        }

        {
            // (16777216) .0.0.0 - .255.255.255
            var addressRange = CidrSubnet.CalculateSubnetRange("10.1.100.30", 8);
            addressRange.StartAddress.Should().Be(IPAddress.Parse("10.0.0.0"));
            addressRange.EndAddress.Should().Be(IPAddress.Parse("10.255.255.255"));
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
        var subnets = new[] { 64 }; // サブネットに分割するビット数の例
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
        var subnets = new[] { 8, 32 }; // サブネットに分割するビット数の例
        foreach (var address in addresses)
        {
            foreach (var subnet in subnets)
            {
                var (startAddress, endAddress) = CidrSubnet.CalculateSubnetRange(address, subnet);
                Console.WriteLine($"{address}, start={startAddress}, end={endAddress}");

                var (startAddress2, endAddress2) = CidrSubnet.CalculateSubnetRange2(address, subnet);
                Console.WriteLine($"{address}, start={startAddress2}, end={endAddress2}");
                startAddress.Should().Be(startAddress2);
                endAddress.Should().Be(endAddress2);
            }
        }
    }
}
