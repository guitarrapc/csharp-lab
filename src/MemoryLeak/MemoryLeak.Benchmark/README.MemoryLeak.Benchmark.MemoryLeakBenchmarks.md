```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **748.4 ns** |   **212.9 ns** |  **11.67 ns** |   **740.7 ns** |   **761.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   714.8 ns |   396.9 ns |  21.76 ns |   691.6 ns |   734.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   708.6 ns |   462.0 ns |  25.32 ns |   693.1 ns |   737.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   746.0 ns |   328.2 ns |  17.99 ns |   729.5 ns |   765.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   703.5 ns |   128.8 ns |   7.06 ns |   696.2 ns |   710.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,542.0 ns** | **2,656.3 ns** | **145.60 ns** | **7,423.3 ns** | **7,704.5 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,329.7 ns | 4,615.6 ns | 253.00 ns | 7,176.4 ns | 7,621.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,044.4 ns | 2,064.0 ns | 113.14 ns | 6,915.5 ns | 7,127.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,195.6 ns | 1,194.8 ns |  65.49 ns | 7,155.1 ns | 7,271.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,291.5 ns | 3,697.8 ns | 202.69 ns | 7,062.6 ns | 7,448.2 ns | 0.1221 | 0.1144 |  10.23 KB |
