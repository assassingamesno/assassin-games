// src/components/Search.js

import React, { useState } from "react";
//import Scroll from './Scroll';
import SearchList from "./SearchList";
import "../styling/components/Search.scss";

function Search({ details }) {
  const [searchField, setSearchField] = useState("");

  const filteredPersons = details.filter((person) => {
    return (
      person.name.toLowerCase().includes(searchField.toLowerCase()) ||
      person.email //legge inn skole her
        .toLowerCase()
        .includes(searchField.toLowerCase())
    );
  });

  const handleChange = (e) => {
    setSearchField(e.target.value);
  };

  function searchList() {
    return <SearchList filteredPersons={filteredPersons} />;
  }

  return (
    <section>
      <div className="grid">
        <h2 className="">Finn din Assassin</h2>
        <input type="search" placeholder="Søk" onChange={handleChange} />
        {searchList()}
      </div>
    </section>
  );
}

export default Search;
