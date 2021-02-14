#pragma once

#if defined(WIN32) || defined(_WIN32)
#include "compatibility.types.h"
#include <filesystem>
#include <fstream>
using namespace std::filesystem;
using namespace std;
unsigned char* readILfromElf(const char* f_name)
{
    const auto fasm = current_path() / f_name;
    printf("[INF] load insomnia assembly '%ls'...\n", fasm.c_str());
    if (!exists(f_name))
    {
        printf("[ERR] failed load insomnia assembly '%ls', file not found.\n", fasm.c_str());
        return nullptr;
    }
    const auto size = file_size(fasm);
    
    auto a = ifstream(fasm, 1 | 32 | 4);

    a.seekg(size - (sizeof(uint32_t) * 2), 0);
    uint32_t len = 0;
    uint32_t offset = 0;
    a.read(reinterpret_cast<char*>(&len), sizeof(uint32_t));
    a.read(reinterpret_cast<char*>(&offset), sizeof(uint32_t));
    a.seekg(offset, 0);
    std::vector<char> bytes(7);
    a.read(bytes.data(), 7);
        
    return (unsigned char*)bytes.data();
}
#endif