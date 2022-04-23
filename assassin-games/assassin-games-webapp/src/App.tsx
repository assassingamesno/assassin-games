import Home from "./components/Home/Home";
import Navbar from "./components/Navbar/Navbar";
import Rules from "./components/Rules/Rules";

/*
import Registration, { RegistrationLanding } from "./components/Registration/Registration";
import About from "./components/About";
import Contestants from "./components/Contestants";
*/

import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./styling/components/Router.scss";
import "./App.scss";
import { rules } from "./data/rules";
import { awards } from "./data/awards";

function App() {
  return (
    <div id="App">
      <Router>
        <Navbar />
        <div id="page-wrap">
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/rules" element={<Rules data={rules} title='regler' pageDesc='En god assassin er en lovlydig'/>} />
            <Route path="/awards" element={<Rules data={awards} title='premier' pageDesc='En god assassin fortjener gode premier'/>} />
            {
              /*
              <Route path="/about" element={<About />} />
              <Route path="/players" element={<Contestants />} />
              <Route path="/registration" element={<Registration />} />
              <Route path="/registration/landing" element={<RegistrationLanding />} />
              */}
          </Routes>
        </div>
      </Router>
    </div>
  );
}

export default App;
