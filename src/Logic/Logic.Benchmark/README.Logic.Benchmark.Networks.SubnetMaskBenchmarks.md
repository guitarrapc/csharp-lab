```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.39 ns** |  **1.924 ns** | **0.105 ns** |    **17.27 ns** |    **17.47 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   108.55 ns |  2.243 ns | 0.123 ns |   108.41 ns |   108.64 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   103.93 ns |  5.036 ns | 0.276 ns |   103.66 ns |   104.21 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    77.57 ns |  2.521 ns | 0.138 ns |    77.41 ns |    77.67 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    44.97 ns |  0.367 ns | 0.020 ns |    44.96 ns |    44.99 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.68 ns | 10.990 ns | 0.602 ns |    43.33 ns |    44.38 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   128.16 ns | 21.237 ns | 1.164 ns |   126.83 ns |   128.99 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **189.28 ns** | **75.829 ns** | **4.156 ns** |   **185.98 ns** |   **193.95 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,082.51 ns | 71.597 ns | 3.924 ns | 1,078.04 ns | 1,085.36 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,057.46 ns | 95.629 ns | 5.242 ns | 1,053.71 ns | 1,063.45 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   792.42 ns | 20.531 ns | 1.125 ns |   791.62 ns |   793.71 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   454.89 ns | 28.101 ns | 1.540 ns |   453.76 ns |   456.65 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   433.67 ns | 14.011 ns | 0.768 ns |   432.80 ns |   434.26 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,174.45 ns | 10.151 ns | 0.556 ns | 1,173.87 ns | 1,174.97 ns | 0.0191 |    1680 B |
