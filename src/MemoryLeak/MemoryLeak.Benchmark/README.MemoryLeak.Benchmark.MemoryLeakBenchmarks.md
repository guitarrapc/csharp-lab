```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **727.7 ns** |   **415.2 ns** |  **22.76 ns** |   **714.0 ns** |   **754.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   698.5 ns |   286.9 ns |  15.72 ns |   681.9 ns |   713.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   672.1 ns |   464.0 ns |  25.44 ns |   655.4 ns |   701.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   726.3 ns |   387.7 ns |  21.25 ns |   711.2 ns |   750.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   717.6 ns |   292.0 ns |  16.01 ns |   704.7 ns |   735.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,425.7 ns** | **3,373.1 ns** | **184.89 ns** | **7,273.6 ns** | **7,631.5 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,299.9 ns | 2,057.2 ns | 112.76 ns | 7,172.6 ns | 7,387.0 ns | 0.1297 | 0.1221 |  10.23 KB |
| AllocateLoH          | 10     | 6,841.8 ns | 4,921.1 ns | 269.74 ns | 6,536.2 ns | 7,046.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,331.7 ns | 1,702.9 ns |  93.34 ns | 7,251.8 ns | 7,434.3 ns | 0.1297 | 0.1221 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,129.0 ns | 1,117.9 ns |  61.27 ns | 7,059.0 ns | 7,173.0 ns | 0.1297 | 0.1221 |  10.23 KB |
