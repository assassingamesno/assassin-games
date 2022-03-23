import React from "react";

interface props {
  title: string;
  value: string | number;
  options: Array<{
    value: string | number; // How the system wil handle the value
    display: string; // What will be rendered to the GUI
  }>;

  onChange: (event: React.ChangeEvent<HTMLSelectElement>) => void;
}

export default function FormSelect(props: Partial<props>) {
  const renderOptions = props.options.map((optionValue) => {
    return (
      <option key={optionValue.value} value={optionValue.value}>
        {optionValue.display}
      </option>
    );
  });

  const renderBlankOption = props.value ? (
    <></>
  ) : (
    <option disabled value={props.value}></option>
  );

  return (
    <div className="FormSelect">
      <div className="FormFieldTitle">{props.title}</div>
      <select
        value={props.value}
        onChange={props.onChange}
        className="FormSelectInput"
      >
        {
          /*props.value ? <></> : <option disabled ></option>*/ renderBlankOption
        }
        {renderOptions}
      </select>
    </div>
  );
}
